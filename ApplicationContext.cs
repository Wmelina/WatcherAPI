﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;


namespace WatcherAPI
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=92.53.127.181;UserID=root;Password=root;database=prod;");
        }
    }
}
