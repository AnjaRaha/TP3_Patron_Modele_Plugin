using System;
using System.Collections.Generic;
using System.Text;

namespace UsersPlugin
{
    public class User
    {
        public String first_name { get; set; }
        public String last_name { get; set; }
        public String email { get; set; }

        public User(String Nom, String Prenom, String Mail)
        {
            this.first_name = Nom;
            this.last_name = Prenom;
            this.email = Mail;
        }

    }
}
