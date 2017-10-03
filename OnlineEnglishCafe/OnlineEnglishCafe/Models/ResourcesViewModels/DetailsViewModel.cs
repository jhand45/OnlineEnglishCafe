using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEnglishCafe.Models.ResourcesViewModels
{
    public class DetailsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorSecondName { get; set; }
        public DateTime Published { get; set; }
        public DateTime Edited { get; set; }
    }
}
