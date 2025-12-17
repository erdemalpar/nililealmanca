using GermanLearningApp.Mvc.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace GermanLearningApp.Mvc.Services
{
    public class UserService
    {
        private readonly string _filePath;
        private List<User> _users;

        public UserService(IWebHostEnvironment env)
        {
            _filePath = Path.Combine(env.ContentRootPath, "users.json");
            LoadUsers();
            
            bool saveNeeded = false;

            // Ensure default Admin exists
            if (!_users.Any(u => u.Role == "Admin"))
            {
                _users.Add(new User
                {
                    Username = "admin",
                    Password = "5225", 
                    Role = "Admin",
                    AllowedPages = new List<string>() 
                });
                saveNeeded = true;
            }

            // Ensure default Student exists (for testing/demo)
            if (!_users.Any(u => u.Username.ToLower() == "nil"))
            {
                _users.Add(new User
                {
                   Username = "nil",
                   Password = "123",
                   Role = "User",
                   Class = "10-A",
                   AllowedPages = new List<string>()
                });
                saveNeeded = true;
            }

            if (saveNeeded)
            {
                SaveUsers();
            }
        }

        private void LoadUsers()
        {
            bool saveNeeded = false; // Moved logic to Constructor or here? 
            // Better to keep LoadUsers simple and do the check in Constructor.
            
            if (File.Exists(_filePath))
            {
                try
                {
                    string json = File.ReadAllText(_filePath);
                    _users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
                }
                catch
                {
                    _users = new List<User>();
                }
            }
            else
            {
                _users = new List<User>();
            }
        }

        private void SaveUsers()
        {
            try
            {
                string json = JsonSerializer.Serialize(_users, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_filePath, json);
            }
            catch { /* Handle error */ }
        }

        public User? ValidateUser(string username, string password)
        {
            // Case insensitive username
            return _users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower() && u.Password == password);
        }

        public bool RegisterUser(string username, string password, string userClass)
        {
            if (_users.Any(u => u.Username.ToLower() == username.ToLower()))
            {
                return false; // User already exists
            }

            var newUser = new User
            {
                Username = username,
                Password = password,
                Class = userClass,
                Role = "User",
                AllowedPages = new List<string>() // Default no access? Or maybe specific defaults? Let's leave empty.
            };

            _users.Add(newUser);
            SaveUsers();
            return true;
        }

        public List<User> GetAllStudents()
        {
            return _users.Where(u => u.Role == "User").ToList();
        }

        public User? GetUser(string username)
        {
            return _users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());
        }

        public void UpdatePermissions(string username, List<string> allowedPages)
        {
            var user = _users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());
            if (user != null)
            {
                user.AllowedPages = allowedPages ?? new List<string>();
                SaveUsers();
            }
        }
    }
}
