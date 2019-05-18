using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11.Models
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        public string NoteName { get; set; }
        public string NoteContent { get; set; }
        public string RecruiterName { get; set; }
    }
}
