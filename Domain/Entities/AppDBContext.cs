using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() { }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string solutiondir = Directory.GetParent(
                    Directory.GetCurrentDirectory()).Parent.FullName;
                IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(solutiondir + "\\quanlyStudent\\quanlyStudent")
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }
    }
}
