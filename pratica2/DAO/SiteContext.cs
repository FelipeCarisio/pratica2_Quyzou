﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pratica2.Models;
using Microsoft.EntityFrameworkCore;

namespace pratica2.DAO
{
    public class SiteContext : DbContext
    {
        public DbSet<usuario> Usuario { get; set; }

        public DbSet<pergunta> Perguntas { get; set; }

        public DbSet<resposta> Respostas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=regulus.cotuca.unicamp.br;Initial Catalog=BD18185; User ID=BD18185; Password=1223302017fod");
        }
    }
}