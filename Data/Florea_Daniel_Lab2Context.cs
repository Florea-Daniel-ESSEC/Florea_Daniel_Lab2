﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Florea_Daniel_Lab2.Models;

namespace Florea_Daniel_Lab2.Data
{
    public class Florea_Daniel_Lab2Context : DbContext
    {
        public Florea_Daniel_Lab2Context (DbContextOptions<Florea_Daniel_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Florea_Daniel_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Florea_Daniel_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Florea_Daniel_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
