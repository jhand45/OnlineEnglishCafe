using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEnglishCafe.Models.AccountViewModels
{
    public class TeacherRegistrationViewModel
    {
        public ApplicationUser ApplicationUser { get; set; }
        public Teacher Teacher { get; set; }
    }
}
