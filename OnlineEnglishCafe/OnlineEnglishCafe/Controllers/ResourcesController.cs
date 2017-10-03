using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using OnlineEnglishCafe.Models.ArticleViewModels;
using OnlineEnglishCafe.Services;
using OnlineEnglishCafe.Models.ArticlesModels;
using Microsoft.AspNetCore.Identity;
using OnlineEnglishCafe.Models;
using System.Security.Claims;
using OnlineEnglishCafe.Data;
using OnlineEnglishCafe.Models.ResourcesViewModels;

namespace OnlineEnglishCafe.Controllers
{
    [AllowAnonymous]
    public class ResourcesController : Controller
    {
        private IResources _resources;
        private UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext _context;

        public ResourcesController(ApplicationDbContext context, IResources resources, 
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _resources = resources;
            _userManager = userManager;
        }


        public IActionResult Index()
        {
            //get everything as a list
            var allArticles = _resources.GetAll();

            if (allArticles == null)
            {
                return View();
            }

            else
            {
                //put everything returned into the listing model
                var Listing = allArticles
                    .Select(result => new ArticleIndexListingModel
                    {
                        Id = result.Id,
                        Title = result.Title,
                        AuthorFirstName = result.Author.FirstName,
                        AuthorSecondName = result.Author.SecondName,
                        Published = result.Published,
                        Edited = result.Edited
                    });

                var model = new ArticleIndexModel()
                {
                    ArticleList = Listing
                };

                return View(model);

            }
        }//end Index

        public IActionResult Details(int id)
        {
            //pulls article by id
            var article = _resources.GetById(id);

            var model = new DetailsViewModel
            {
                Title = article.Title,
                AuthorFirstName = article.Author.FirstName,
                AuthorSecondName = article.Author.SecondName,
                Content = article.Content,
                Published = article.Published,
                Edited = article.Edited
            };

            return View(model);
        }


        //[Authorize]
        [HttpGet]
        public IActionResult CreateArticle (string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        //[Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateArticle(CreateArticleViewModel model)
        {
            ////identify userid - I'm using name but I'd prefer int
            var _userId = this.User.Identity.Name;

            ////find applicationuser using id (name)
            var _author = _resources.GetUserData(_userId);

            //find applicationuser author details or creates it
            Author author = _resources.AppUserAsAuthor(_author);


            var newArticle = new Article
            {
                Title = model.Article.Title,
                Content = model.Article.Content,
                Published = DateTime.Now,
                Author = author
            };

            _resources.Create(newArticle);

            return View("PostConfirm");
        }

    }//end controller
}//end namspace