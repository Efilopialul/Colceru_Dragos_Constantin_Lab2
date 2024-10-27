﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Colceru_Dragos_Constantin_Lab2.Models;

namespace Colceru_Dragos_Constantin_Lab2.Data
{
    public class Colceru_Dragos_Constantin_Lab2Context : DbContext
    {
        public Colceru_Dragos_Constantin_Lab2Context (DbContextOptions<Colceru_Dragos_Constantin_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Colceru_Dragos_Constantin_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Colceru_Dragos_Constantin_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Colceru_Dragos_Constantin_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
