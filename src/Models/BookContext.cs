﻿using Microsoft.EntityFrameworkCore;

namespace CRUD.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
