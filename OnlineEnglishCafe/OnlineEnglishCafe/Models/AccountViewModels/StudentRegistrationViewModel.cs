using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEnglishCafe.Models.AccountViewModels
{
    public class StudentRegistrationViewModel
    {
        public ApplicationUser ApplicationUser { get; set; }
        public Student Student { get; set; }
    }
}
