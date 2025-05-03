using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    //represwnts a single user (driver or manager)
    public class User
    {
        public string Name {  get; set; }       //Users full name
        public string Email { get; set; }       //User's email
        public string Password { get; set; }    //User's password
        public string Role { get; set; }        //"Driver" or "Manager"
    
        //constructor used when creating a new user
        public User(string name, string email, string password, string role) 
        {
            Name = name;
            Email = email;
            Password = password;
            Role = role;

        }
    }
}
