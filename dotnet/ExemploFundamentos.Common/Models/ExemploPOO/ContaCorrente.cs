using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models.ExemploPOO
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            this.NumeroConta = numeroConta;
            this.saldo = saldoInicial;

        }
        //propriedade
        public int NumeroConta { get; set; }
        
        //variavel protegida
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            //saldo = saldo - valor;
            if(saldo >= valor)
            {
                 saldo -= valor;
                Console.WriteLine($"Saque {valor} realizado com sucesso");
            }
            else
            {
                Console.WriteLine("valor a sacar maior que o saldo da conta");
            }
           
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponivel: {saldo}");
        }
    }
}