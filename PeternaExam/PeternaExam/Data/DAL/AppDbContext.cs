using Microsoft.EntityFrameworkCore;
using PeternaExam.Data.Configuration;
using PeternaExam.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeternaExam.Data.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ServiceConfiguration());
            modelBuilder.Entity<Service>().HasData(
            new Service { Id = 1, Icon = "fas fa-desktop", Title = "Sure Quique Menu", Info = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere.", Info2 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." },
            new Service { Id = 2, Icon = "fas fa-flask", Title = "Sure Quique Menu", Info = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere.", Info2 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." },
            new Service { Id = 3, Icon = "far fa-credit-card", Title = "Sure Quique Menu", Info = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere.", Info2 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
