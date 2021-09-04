using System;
using System.Collections.Generic;
using System.Text;
using business;
using business.Intermediario;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SistemaEscolar.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Escola> Escola { get; set; }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Turma> Turma { get; set; }
        public DbSet<TurmaAluno> TurmaAluno { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            base.OnModelCreating(builder);
            builder.Entity<TurmaAluno>()
            .HasKey(p => new { p.TurmaId, p.AlunoId });

        }

    }
}
