using Microsoft.EntityFrameworkCore;
using Senai.InLock.WebApi.CodeFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.CodeFirst.Contexts
{
    /// <summary>
    /// Classe responsponsavel pelo contexto do prejeto
    /// Faz a comunicação entre API e Banco de dados
    /// </summary>
    public class InLockContext : DbContext
    {
        public DbSet<TipoUsuario> TipoUsuario { get; set;  }

        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<Estudio> Estudio { get; set; }

        public DbSet<Jogo> Jogo { get; set; }

        /// <summary>
        /// Define as opções de contrução do banco de dados
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DEV801\\SQLEXPRESS; Database=InLock_Games_CodeFirst; user Id=sa; pwd=sa@132");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoUsuario>().HasData(new TipoUsuario
            {
                IdTipoUsuario = 1,
                Titulo = "Administrador"
            },
            new TipoUsuario
            {
                IdTipoUsuario = 2,
                Titulo = "Cliente"
            });


            modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                IdUsuario = 1,
                Email = "admin@admin.com",
                Senha = "admin",
                IdTipoUsuario = 1
            },
            new Usuarios
            {
                IdUsuario = 2,
                Email = "cliente@cliente.com",
                Senha = "clinete",
                IdTipoUsuario = 2
            });


            modelBuilder.Entity<Estudio>().HasData(new Estudio
            {
                IdEstudio = 1,
                NomeEstudio = "Blizzard"
            },
            new Estudio
            {
                IdEstudio = 2,
                NomeEstudio = "Rockstar Studios"
            },
            new Estudio
            {
                IdEstudio = 3,
                NomeEstudio = "Square Enix"
            });


            modelBuilder.Entity<Jogo>().HasData(new Jogo
            {
                IdJogo = 1,
                NomeJogo = "Diablo 3 ",
                DataDeLancamento = Convert.ToDateTime("15/05/2012"),
                Descricao = "É um jogo que contém bastante ação e é viciante, seja você gamer ou não",
                Valor = Convert.ToDecimal("90,00"),
                IdEstudio = 1

            },
            new Jogo
            {
                IdJogo = 2,
                NomeJogo = "Red Dead Redemption II",
                DataDeLancamento = Convert.ToDateTime("26/10/2018"),
                Descricao = "Jogo eletrônico de ação-aventura western",
                Valor = Convert.ToDecimal("120,00"),
                IdEstudio = 2

            });


        }
    }
}
