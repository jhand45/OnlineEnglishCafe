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

        [ForeignKey("UserID")]
        public int UserID { get; set; }

        [Required]
        [StringLength(30, ErrorMessage ="Everyone has an accent!  If you're unsure of yours, feel free to put in something like 'mixed'")]
        public string Accent { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Please condense your city name")]
        [Display(Name = "Current City")]
        public string City { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "No country has a name that long!")]
        [Display(Name = "Current Country")]
        public string Country { get; set; }

        [Display(Name = "Please tick if English is your first language")]
        public bool Native { get; set; }

        public bool Approved { get; set; }
    }
}
