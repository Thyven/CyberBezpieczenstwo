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
        }

        public List<userData> items;

        // !!!! przerzućcie "plik.json" na Pulpit, jak na ta chwilę takie rozwiązanie.
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "data.json");
        // handle data form JSON
        public void LoadJson()
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<userData>>(json);
            }
        }

        public void DebugData()
        {
            Debug.WriteLine(items[0].passwordExpireDate);
            Debug.WriteLine(items[1].passwordExpireDate);
        }

       

    }
}
