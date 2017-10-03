using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEnglishCafe.Models.ArticlesModels
{
    public class Author
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string ProfileUrl { get; set; }

        public ICollection<Article> Articles { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
