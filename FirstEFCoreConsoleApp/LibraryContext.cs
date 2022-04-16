using FirstEFCoreConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FirstEFCoreConsoleApp
{
    class LibraryContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FirstEFCoreConsoleApp", "library.db");
            var dbDir = Path.GetDirectoryName(dbPath);

            if (!Directory.Exists(dbDir))
            {
                Directory.CreateDirectory(dbDir);
            }
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

}
}
