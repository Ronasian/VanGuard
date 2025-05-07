using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GroupProject.Models;
using Newtonsoft.Json;

namespace GroupProject.Data
{
    public static class CsvToJsonConverter
    {
        private static readonly string CsvPath = "users.csv";
        private static readonly string JsonPath = "users.json";

        public static void ConvertUsersCsvToJson()
        {
            if (!File.Exists(CsvPath))
            {
                Console.WriteLine("CSV file not found.");
                return;
            }

            var lines = File.ReadAllLines(CsvPath);
            var users = new List<User>();

            foreach (var line in lines.Skip(1))
            {
                var parts = line.Split(',');
                if (parts.Length >= 4)
                {
                    users.Add(new User(
                        parts[0].Trim(),
                        parts[1].Trim(),
                        parts[2].Trim(),
                        parts[3].Trim()
                    ));
                }
            }

            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(JsonPath, json);
        }
    }
}
