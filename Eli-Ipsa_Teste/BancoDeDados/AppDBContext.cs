using Eli_Ipsa_Teste.Entities;
using Eli_Ipsa_Teste.Entities.Enums;
using Eli_Ipsa_Teste.BancoDeDados.EntidadesRelacionamento;
using Microsoft.EntityFrameworkCore;

namespace Eli_Ipsa_Teste.BancoDeDados
{
    public class AppDbContext : DbContext
    {
        //public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Entrevista> Entrevistas { get; set; }
        public DbSet<CoEntrevistadoresEntrevista> CoEntrevistadoresEntrevista { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Preceptoria> Preceptorias { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<AlunosDepartamento> AlunosDepartamneto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contato>()
                .Property(x => x.TipoContato)
                .HasConversion(typeof(string));

            modelBuilder.Entity<Curso>()
                .Property(x => x.NivelCurso)
                .HasConversion(typeof(string));

            modelBuilder.Entity<Entrevista>()
                .Property(x => x.Resultado)
                .HasConversion(typeof(string));

            //modelBuilder.Entity<Candidato>()
            //    .Property(x => x.Tipo_Contato)
            //    .HasConversion(typeof(string));


        }
    }
}
