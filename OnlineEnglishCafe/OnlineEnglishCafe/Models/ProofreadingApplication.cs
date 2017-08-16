using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace OnlineEnglishCafe.Models
{
    public class ProofreadingApplication
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "You should consider condensing your first name for our purposes")]
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
        [Display(Name = "Type of Submission")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Word Count")]
        public int WordCount { get; set; }

        [Required]
        [Display(Name = "Purpose of Submission")]
        public string Purpose { get; set; }

    }
}
