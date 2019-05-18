using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11.Models
{
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        public string JobTitle { get; set; }
        public string Location { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Description { get; set; }

        public int? CompanyId { get; set; }
        public Company Company { get; set; }

    }
}
