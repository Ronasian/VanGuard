using GroupProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GroupProject.Data
{
    public static class VanDatabase
    {
        private static readonly string FilePath = "vans.json";
        public static List<Van> Vans { get; private set; } = new List<Van>();

        static VanDatabase()
        {
            LoadVans();
        }

        public static void AddVan(Van van)
        {
            Vans.Add(van);
            SaveVans();
        }

        public static void RemoveVan(string vanId)
        {
            Vans.RemoveAll(v => v.Id == vanId);
            SaveVans();
        }

        public static void SaveVans()
        {
            var json = JsonConvert.SerializeObject(Vans, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public static void LoadVans()
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                Vans = JsonConvert.DeserializeObject<List<Van>>(json) ?? new List<Van>();
            }
        }

        public static Van GetVanById(string id)
        {
            return Vans.Find(v => v.Id == id);
        }

        public static void UpdateVan(Van updated)
        {
            var index = Vans.FindIndex(v => v.Id == updated.Id);
            if (index != -1)
            {
                Vans[index] = updated;
                SaveVans();
            }
        }
    }
}
