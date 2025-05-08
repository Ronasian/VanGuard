using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GroupProject.Models;

namespace GroupProject.Data
{
    public static class UserDatabase
    {
        private static string filePath = "users.csv";
        private static List<User> users = new List<User>();

        static UserDatabase()
        {
            LoadUsers();
        }

        private static void LoadUsers()
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "Name,Email,Password,Role" + Environment.NewLine);
            }

            var lines = File.ReadAllLines(filePath).Skip(1);
            users = lines.Select(line =>
            {
                var parts = line.Split(',');
                return new User(parts[0], parts[1], parts[2], parts[3]);
            }).ToList();
        }

        public static void AddUser(User user)
        {
            users.Add(user);
            File.AppendAllText(filePath, $"{user.Name},{user.Email},{user.Password},{user.Role}{Environment.NewLine}");
        }

        public static User Authenticate(string email, string password)
        {
            return users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public static bool EmailExists(string email)
        {
            return users.Any(u => u.Email == email);
        }

        public static List<User> GetAllUsers() => users;
    }
}
