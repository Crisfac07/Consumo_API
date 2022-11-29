using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIBooks.Models;

namespace APIBooks.Data
{
    public class APIBooksContext : DbContext
    {
        public APIBooksContext(DbContextOptions<APIBooksContext> options) : base(options)
        {

        }
        public DbSet<Author>Author{get; set;}
    }
}
