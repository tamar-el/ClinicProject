﻿using clinicProject.core.Entities;

namespace clinicProject.Models
{
    public class PatientModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public long phone { get; set; }
        public string email { get; set; }
       
    }
}