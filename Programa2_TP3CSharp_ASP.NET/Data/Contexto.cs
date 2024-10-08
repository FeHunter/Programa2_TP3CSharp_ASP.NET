﻿using Microsoft.EntityFrameworkCore;
using Programa2_TP3CShpar_ASP.NET.Models;

namespace Programa2_TP3CSharp_ASP.NET.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Passaporte> Passaportes { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .HasOne(p => p.Passaporte)
                .WithOne(p => p.Pessoa)
                .HasForeignKey<Passaporte>(p => p.PassaportId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
