using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineEnglishCafe.Models;
using OnlineEnglishCafe.Models.ArticlesModels;

namespace OnlineEnglishCafe.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        //users
        public DbSet<OnlineEnglishCafe.Models.ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Admin> Admins { get; set; }

        //resources
        public DbSet<Author> Authors { get; set; }
        public DbSet<Article> Articles { get; set; }

        //proofreading
        public DbSet<ProofreadingApplication> ProofreadingApplication { get; set; }

    }
}
