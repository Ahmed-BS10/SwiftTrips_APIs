﻿using DataAccess_Layer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AppDbContext : DbContext
    {
        const string _dbConnectionString =

            "Server=.;Database=OnlineStoreDB;User Id=sa;Password=sa123456;TrustServerCertificate=true";


        public AppDbContext()
        {
        }
  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbConnectionString);
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<eCountriesDA>().HasKey(e=> e.CountryID);
        }



        //tabels



        public DbSet<eCountriesDA> Countries {  get; set; }


        

    }
}
