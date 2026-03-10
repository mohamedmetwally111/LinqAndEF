using System;
using System.Collections.Generic;
using System.Text;

namespace Health_Care_System.Models
{
    internal class Appointment
    {
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public DateTime AppointmentDate { get; set; }
    }
}
