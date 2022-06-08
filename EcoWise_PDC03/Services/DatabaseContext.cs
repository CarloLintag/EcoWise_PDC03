using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using EcoWise_PDC03.Model;
using System.IO;


namespace EcoWise_PDC03.Services
{
    public class DatabaseContext: DbContext
    {
        public DbSet<AnimalModel> Animals { get; set; }
        public DatabaseContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "AnimalList.db");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}
