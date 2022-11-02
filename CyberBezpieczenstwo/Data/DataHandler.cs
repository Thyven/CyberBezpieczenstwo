using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBezpieczenstwo.Data
{
    internal class DataHandler
    {
        public List<UserData> items;
        private string path;
        public DataHandler()
        {
            path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\data.json";
            LoadJson();
        }

        // !!!! przerzućcie "plik.json" na Pulpit, jak na ta chwilę takie rozwiązanie.
        // handle data form JSON
        private void LoadJson()
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<UserData>>(json);
            }
        }

        public void SaveJson()
        {
            var json = JsonConvert.SerializeObject(items);
            File.WriteAllText(path, json);
        }

        public List<UserData> GetUsers()
        {
            LoadJson();
            return items.OrderBy(x => x.userID).ToList();
        }


        public bool ChangeUsername(string oldUsername, string newUsername)
        {
            var user = GetUsers().Where(x => x.username == oldUsername).FirstOrDefault();
            if (user == null) return false;
            else
            {
                var newUser = user;
                newUser.username = newUsername;
                items.Remove(user);
                items.Add(newUser);
                SaveJson();
            }
            return true;
        }

        public bool ChangePassword(string username, string newPassword, bool isRegexNeeded)
        {
            var validate = new Validate();
            if (!validate.checkRegex(newPassword, isRegexNeeded)) return false;
            var user = GetUsers().Where(x => x.username == username).FirstOrDefault();
            if (user == null) return false;
            var userWithNewPassword = user;
            userWithNewPassword.password = newPassword;
            items.Remove(user);
            items.Add(userWithNewPassword);
            SaveJson();
            return true;
        }

        public UserData CreateUser(string username, string password, string role)
        {
            var highestId = items.OrderByDescending(x => x.userID).First().userID;
            var newUser = new UserData();
            newUser.userID = highestId + 1;
            newUser.username = username;
            newUser.password = password;
            newUser.role = role;
            items.Add(newUser);
            SaveJson();
            return newUser;
        }

        public bool DeleteUser(string username)
        {
            if (string.IsNullOrEmpty(username)) return false;
            var userForRemove = GetUsers().Where(x => x.username == username).First();
            if (userForRemove == null) return false;
            items.Remove(userForRemove);
            SaveJson();
            return true;
        }

    }
}
