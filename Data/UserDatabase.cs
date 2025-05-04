using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroupProject.Models;

namespace GroupProject.Data
{
    //A static class to store and manage user data
    public static class UserDatabase
    {
        private static readonly string FilePath = "users.json"; //file to store user data
        public static List<User> Users { get; private set; } = new List<User>(); //In-memory list of users

        //static constructor that loads user data when the app starts
        static UserDatabase()
        {
            LoadUsers();
        }

        //adds a new user to the list and saves to the file
        public static void AddUser(User user)
        {
            Users.Add(user);
            SaveUsers();
        }

        //Finds a user by email and password for login validation
        public static User Authenticate(string email, string password) 
        {
            return Users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        //saves the current list of users to a JSON file
        private static void SaveUsers() 
        {
            var json = JsonConvert.SerializeObject(Users, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        //loads users from the JSON file into memory
        private static void LoadUsers() 
        {
            if (File.Exists(FilePath)) 
            {
                var json = File.ReadAllText(FilePath);
                Users = JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
            }
        }

    }
}
