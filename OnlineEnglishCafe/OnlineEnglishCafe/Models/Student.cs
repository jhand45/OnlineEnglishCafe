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
        [Key]
        public int StudentId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        
        [Required]
        [StringLength(30, ErrorMessage = "Please condense your city name")]
        [Display(Name = "Current City")]
        public string City { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "No country has a name that long!")]
        [Display(Name = "Current Country")]
        public string Country { get; set; }

        [Display(Name ="Bio")]
        public string Bio { get; set; }

        [Display(Name = "Tell us why you are learning English?")]
        public string Purpose { get; set; }
    }
}
