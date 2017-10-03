using OnlineEnglishCafe.Models;
using OnlineEnglishCafe.Models.ArticlesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEnglishCafe.Services
{
    public interface IResources //defines methods for resources
    {
        IEnumerable<Article> GetAll();
        void Create(Article newArticle);
        Article GetById(int id);

        Author AppUserAsAuthor(ApplicationUser author);


        ApplicationUser GetUserData(string userId);


    }
}
