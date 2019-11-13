using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Numele { get; set; }
        public string Sectia { get; set; }
        public int An { get; set; }
    }
}
