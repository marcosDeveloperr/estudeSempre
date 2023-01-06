using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models.ExemploPOO
{
    public class Professor : Pessoa
    {
        //construtor default
        public Professor()
        {
            
        }

        //porque pai tem construtor com o parâmetro nome
        //base - recebendo o parâmetro nome e passo para a classe pai 
        public Professor(string nome) : base(nome) { }
        public decimal Salario { get; set; }
        
        //override - sobrescrever
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e ganho {Salario}");
        }
    }
}