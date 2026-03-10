using System;
using System.Collections.Generic;
using System.Text;

namespace Health_Care_System.Models
{
    internal class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        
        public List<Appointment> Appointments { get; set; }
    }
}
