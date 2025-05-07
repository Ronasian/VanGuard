using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class Van
    {
        // randomly assigned ID (4 digits)
        public string Id { get; set; }
        // if unassigned, return null. should display driver email
        public string AssignedDriver { get; set; }
        // Active or Out of Service
        public string Status { get; set; } 
        // yes or no
        public bool NeedsRepair { get; set; }
        // driver side entries for vehicle
        public string Report { get; set; }
    }
}
