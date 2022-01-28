using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeternaExam.Data.Entities
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        public string Icon { get; set; }
        [Required,MaxLength(50,ErrorMessage = "Title Must be less 50")]
        public string Title { get; set; }
        
        [Required, MaxLength(250, ErrorMessage = "Info Must be less 250")]
        public string Info { get; set; }
        
        [Required, MaxLength(150, ErrorMessage = "Info Must be less 150")]
        public string Info2 { get; set; }
    }
}
