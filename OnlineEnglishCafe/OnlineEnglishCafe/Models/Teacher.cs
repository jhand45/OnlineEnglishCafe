using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace OnlineEnglishCafe.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "You should consider condensing your first name for our site")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "You might need to give us an abbreviated Last Name")]
        [Display(Name = "Second Name")]
        public string SecondName { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

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
