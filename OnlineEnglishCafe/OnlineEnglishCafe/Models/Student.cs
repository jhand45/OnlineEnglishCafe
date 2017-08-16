using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEnglishCafe.Models
{
    public class Student
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
        [StringLength(30, ErrorMessage = "Please condense your city name")]
        [Display(Name = "Current City")]
        public string City { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "No country has a name that long!")]
        [Display(Name = "Current Country")]
        public string Country { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Passwords Do Not Match")]
        public string Confirm { get; set; }

        [Display(Name ="Bio")]
        public string Bio { get; set; }
    }
}
