using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEnglishCafe.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
