using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineEnglishCafe.Data;
using OnlineEnglishCafe.Models;
using OnlineEnglishCafe.Models.ArticlesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEnglishCafe.Services
{
    public class ResourceServices : IResources
    {
        private ApplicationDbContext _context;

        public ResourceServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Article> GetAll()
        {
            return _context.Articles
                .Include(article => article.Author)
                ; //include values that return a class
        }

        public void Create(Article newArticle)
        {
            _context.Add(newArticle);
            _context.SaveChanges();
        }
        
        public ApplicationUser GetUserData(string userId)
        {
            return _context.ApplicationUser
                .FirstOrDefault(id => id.UserName == userId);
        }

        public Author AppUserAsAuthor(ApplicationUser author)
        {
            //checks
            var authorExists = _context.Authors
                .Where(a => a.ApplicationUser.UserId == author.UserId)
                .FirstOrDefault();

            //if it doesnt find anything
            if(authorExists == null)
            {
                var newAuthor = new Author
                {
                    FirstName = author.FirstName,
                    SecondName = author.SecondName,
                    Email = author.Email
                };

                return newAuthor;
            }

            //if it does
            return authorExists;
        }

        public Article GetById(int id)
        {
            return GetAll()
                .FirstOrDefault(a => a.Id == id);
        }

    }//end dbservices
}//end namespace
