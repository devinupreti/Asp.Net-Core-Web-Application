using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11.Models
{
    public class Education
    {
        [Key]
        public int EducationId { get; set; }
        public string InstituteName { get; set; }
        public string Location { get; set; }
        public string Degree { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
