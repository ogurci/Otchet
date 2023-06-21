using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.module
{
    public class ApplicationContext : DbContext
    {
        public DbSet<TypesOfDivision> TypesOfDivision { get; set; } = null!;
        public DbSet<MainTypes> MainTypes { get; set; } = null!;
        public DbSet<OtherTypes> OtherTypes { get; set; } = null!;
        public DbSet<MainCheckOuts> MainCheckOuts { get; set; } = null!;
        public DbSet<OtherCheckOuts> OtherCheckOuts { get; set; } = null!;

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }
    }

   

}
