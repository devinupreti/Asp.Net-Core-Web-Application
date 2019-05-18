using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11.Models
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        public string RequestName { get; set; }
        public string RequestContent { get; set; }
        public string RecruiterName { get; set; }
    }
}
