using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineEnglishCafe.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        
        [Required]
        [StringLength(30, ErrorMessage ="Everyone has an accent!  If you're unsure of yours, feel free to put in something like 'mixed'")]
        public string Accent { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Please condense your location")]
        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = "Please tick if English is your first language")]
        public bool Native { get; set; }

        [Display(Name = "Tell us about yourself?")]
        public string Bio { get; set; }

        public bool Approved { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
