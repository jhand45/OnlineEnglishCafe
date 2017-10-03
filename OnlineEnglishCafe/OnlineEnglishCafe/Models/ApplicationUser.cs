using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace OnlineEnglishCafe.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int UserId { get; set; }

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
        public override string Email { get; set; }

        public virtual MembershipType MembershipType { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Invalid Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public enum MembershipType
    {
        Admin,
        Teacher,
        Student
    }
}
