using OnlineEnglishCafe.Models.ArticlesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEnglishCafe.Models.ArticlesModels
{
    public class DT
    {
        DateTime now = DateTime.Now;
    }

    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImgUrl { get; set; }

        public DateTime Published { get; set; }
        public DateTime Edited { get; set; }

        public Author Author { get; set; }

    }
}
