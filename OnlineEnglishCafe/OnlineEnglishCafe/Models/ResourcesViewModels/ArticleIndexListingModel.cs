using OnlineEnglishCafe.Models.ArticlesModels;
using System;

namespace OnlineEnglishCafe.Models.ArticleViewModels
{
    public class ArticleIndexListingModel
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorSecondName { get; set; }

        public DateTime Published { get; set; }
        public DateTime Edited { get; set; }
    }
}