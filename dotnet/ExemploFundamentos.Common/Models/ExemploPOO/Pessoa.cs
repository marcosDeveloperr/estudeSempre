using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models.ExemploPOO
{
    public class Pessoa
    {
        //Construtor default
        public Pessoa()
        {
            
        }

        //instanciar um objeto da classe pessoa e classes filha sendo obrigatorio ter nome
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string Email { get; set; }

        public virtual void  Apresentar() //virtual - polimorfismo - agora pode sobrescrever o método Apresentar()
         {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}