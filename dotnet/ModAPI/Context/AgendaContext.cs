using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModAPI.Entities; //reconhecer Contato.cs



namespace ModAPI.Context
{
    //utilizamo no BD do Pacote Microsoft.EntityFramewokCore
    //Herdamos a classe DbContext porque tem as operações que 
    public class AgendaContext : DbContext
    {
        //Apontamento para o banco de dados utilizado
        public AgendaContext(DbContextOptions<AgendaContext>options): base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}