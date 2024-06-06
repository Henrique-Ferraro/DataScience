using Microsoft.EntityFrameworkCore;
using appMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appMVC.models;

namespace appMVC.Data
{
    public class ConnectDB : DbContext
    {
        public ConnectDB(DbContextOptions<ConnectDB> opt) : base (opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<mdlEndereco>()
                .HasOne(endereco => endereco.Pessoa)
                .WithOne(pessoa => pessoa.Endereco)
                .HasForeignKey<mdlPessoa>(pessoa => pessoa.EnderecoId);

            //builder.entity<mdltelefone>()
            //    .hasone(telefone => telefone.pessoas)
            //    .withone(pessoa => pessoa.telefone)
            //    .hasforeignkey<mdltelefone>(pessoa => pessoa.telefoneid);
        }

        public DbSet<mdlPessoa> Pessoas { get; set; }
        public DbSet<mdlEndereco> Enderecos { get; set; }
        public DbSet<mdlTelefone> Telefones { get; set; }
        public DbSet<mdlManager> Managers { get; set; }

    }
}
