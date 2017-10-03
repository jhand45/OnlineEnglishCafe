using OnlineEnglishCafe.Models.ArticlesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEnglishCafe.Models.ArticleViewModels
{
    public class ArticleIndexModel
    {
        public IEnumerable<ArticleIndexListingModel> ArticleList { get; set; }
    }
}
