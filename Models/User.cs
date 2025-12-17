using System.Collections.Generic;

namespace GermanLearningApp.Mvc.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; } // In a real app, this should be hashed!
        public string Role { get; set; } // "Admin" or "User"
        public string Class { get; set; } // e.g. "10-A"
        
        // List of allowed paths/lessons. If null/empty, maybe allow all or none?
        // Let's assume for "User" role, if this list is empty, they might have basic access or no access.
        // We will implement logic: Admin has full access. User has access only to what is in this list + public pages.
        public List<string> AllowedPages { get; set; } = new List<string>();
    }
}
