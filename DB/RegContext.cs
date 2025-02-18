﻿using DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class RegContext: DbContext //IdentityDbContext
    {
        public RegContext(DbContextOptions<RegContext> options): base(options){ }

        public DbSet<Curso> Cursos { get; set; }
    }
}
