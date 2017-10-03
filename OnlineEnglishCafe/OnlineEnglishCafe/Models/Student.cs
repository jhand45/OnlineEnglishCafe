using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEnglishCafe.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Please condense your location")]
        [Display(Name = "Current Location")]
        public string Location { get; set; }

        [StringLength(30, ErrorMessage = "Please tell us in less than 30 characters")]
        [Display(Name = "What is your native language?")]
        public string Native { get; set; }

        [Display(Name ="Tell us about yourself?")]
        public string Bio { get; set; }

        [Display(Name = "Tell us why you are learning English?")]
        public string Purpose { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
