using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIBooks.Models;

namespace BooksMVC.Data
{
    public class BooksMVCContext : DbContext
    {
        public BooksMVCContext (DbContextOptions<BooksMVCContext> options)
            : base(options)
        {
        }

        public DbSet<APIBooks.Models.Author> Author { get; set; }
    }
}
