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
        public class userData
        {
            public int userID;
            public string username;
            public string password;
            public string passwordExpireDate;
            public string role;
            public List<string> oldPasswords;
        }

        public List<userData> items;

        // !!!! przerzućcie "plik.json" na Pulpit, jak na ta chwilę takie rozwiązanie.
        // handle data form JSON
        public void LoadJson(string fileName)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<userData>>(json);
            }
        }

        public void SaveJson()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "data.json");
            var json = JsonConvert.SerializeObject(items);
            File.WriteAllText(path, json);
        }

        public void DebugData()
        {
            Debug.WriteLine(items[0].oldPasswords[0]);
            Debug.WriteLine(items[1].oldPasswords[1]);
        }




       

    }
}
