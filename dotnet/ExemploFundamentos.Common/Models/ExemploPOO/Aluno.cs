using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models.ExemploPOO
{
    public class Aluno : Pessoa //Aluno herdando de Pessoa - Herança
    {
        public double Nota { get; set; }

        //que estar herdando.
        //a palavra reservada virtual em seu método na classe Pessoa
        //override  - sobrescreva -  o método Apresentar que recebeu
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota} ");
        }
    }
}