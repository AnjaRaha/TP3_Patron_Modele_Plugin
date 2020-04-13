using PluginBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UsersPlugin
{
    class ReadUsers : ICommand
    {
        public string Name { get => "GetUsers"; }
        public string Description { get => "Displays users"; }

        public int Execute()
        {
            List<User> liste = getUsers();
            foreach(User user in liste)
            {
                Console.WriteLine(user.first_name + ' ' + user.last_name + ' ' +' ' + user.email) ;

            }
            Console.WriteLine("Nombre total:" + liste.Count());
            return 0;
        }

        public List<User> getUsers()
        {
            try
            {
                List<User> liste = new List<User>();
      
                String path =  Environment.CurrentDirectory;
                path+=@"\Users\";
                foreach (string file in Directory.EnumerateFiles(path))
                {
                    //string contents = File.ReadAllText(file);
                    using (System.IO.StreamReader r = new System.IO.StreamReader(file))
                    {
                        string json = r.ReadToEnd();
                        List<User> listeFichier = new List<User>();
                        listeFichier = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(json);
                        liste = liste.Union(listeFichier).ToList();
                    }
                }




                return liste;
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }
    }
}
