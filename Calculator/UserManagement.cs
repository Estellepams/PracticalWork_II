using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace Calculator
{
    public class UserManagement
    {
        //"C:/Users/estel/OneDrive/Desktop/OOP/Calculator/User.json"
        private const string FilePath = "C:/Users/estel/OneDrive/Desktop/OOP/Calculator/User.json";
        private List<User> users;

        public UserManagement()
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                users = JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
            }
            else
            {
                users = new List<User>();
            }
            
        }
        private void SaveUsers()
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }
        public bool RegisterUser(User newUser)
        {
            if (users.Exists(u => u.Username == newUser.Username))
            {
                return false; // Username already exists
            }

            users.Add(newUser);
            SaveUsers();
            return true;
        }
        public User AuthenticateUser(string username, string password)
        {
            return users.Find(u => u.Username == username && u.Password == password);
        }

        public User GetUserByUsername(string username)
        {
            return users.Find(u => u.Username == username);
        }
        public void UpdateUser(User updatedUser)
        {
            var user = users.Find(u => u.Username == updatedUser.Username);
            if (user != null)
            {
                user.Name = updatedUser.Name;
                user.Password = updatedUser.Password;
                SaveUsers();
            }
        }

    }
}
