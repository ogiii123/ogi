using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp1.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp1.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}
           
            public DbSet<Value> Values { get; set; }
        
    }
}