using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMvcApp.Models;

namespace MyMvcApp.Data
{
    public class MvcCelebrityContext : DbContext
    {
        public MvcCelebrityContext (DbContextOptions<MvcCelebrityContext> options)
            : base(options)
        {
        }

        public DbSet<MyMvcApp.Models.Celebrity> Celebrity { get; set; }
    }
}
