using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Year { get; set; }
        public string Technology { get; set; }
        public string Description { get; set; }

        public int? EducationId { get; set; }
        public Education Education { get; set; }
    }
}
