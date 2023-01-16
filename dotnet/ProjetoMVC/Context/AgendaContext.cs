using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models;

namespace ProjetoMVC.Context
{
    public class AgendaContext : DbContext
    {
        //construtor
        public AgendaContext(DbContextOptions<AgendaContext>options): base(options)
        {
           
        }
        
        //Criando a tabela Contato 
        public DbSet<Contato> Contato {get; set;}
    }
}