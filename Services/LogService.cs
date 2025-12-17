using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GermanLearningApp.Mvc.Services
{
    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public string Action { get; set; } // Login, Logout, ViewPage...
        public string Username { get; set; }
        public string Details { get; set; }
    }

    public class LogService
    {
        private readonly string _filePath;

        public LogService(IWebHostEnvironment env)
        {
            _filePath = Path.Combine(env.ContentRootPath, "logs.json");
        }

        public void Log(string action, string username, string details = "")
        {
            var entry = new LogEntry
            {
                Timestamp = DateTime.Now,
                Action = action,
                Username = username,
                Details = details
            };

            List<LogEntry> logs = new List<LogEntry>();
            if (File.Exists(_filePath))
            {
                try
                {
                    string json = File.ReadAllText(_filePath);
                    logs = JsonSerializer.Deserialize<List<LogEntry>>(json) ?? new List<LogEntry>();
                }
                catch { /* Ignore read errors */ }
            }

            logs.Add(entry);

            // Keep only last 1000 logs to prevent infinite growth
            if (logs.Count > 1000)
            {
                logs = logs.GetRange(logs.Count - 1000, 1000);
            }

            try
            {
                string json = JsonSerializer.Serialize(logs, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_filePath, json);
            }
            catch { /* Ignore write errors */ }
        }

        public List<LogEntry> GetLogs()
        {
            if (!File.Exists(_filePath)) return new List<LogEntry>();
            try
            {
                string json = File.ReadAllText(_filePath);
                var logs = JsonSerializer.Deserialize<List<LogEntry>>(json);
                // Return reversed list to show newest first
                logs?.Reverse();
                return logs ?? new List<LogEntry>();
            }
            catch
            {
                return new List<LogEntry>();
            }
        }
    }
}
