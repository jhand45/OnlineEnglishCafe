using OnlineEnglishCafe.Models.ArticlesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEnglishCafe.Models.ArticleViewModels
{
    public class CreateArticleViewModel
    {
        public Author Author { get; set; }
        public Article Article { get; set; }
    }
}
