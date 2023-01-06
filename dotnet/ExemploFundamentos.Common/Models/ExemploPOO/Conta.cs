using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models.ExemploPOO
{
    public abstract class Conta
    {
        //protected - atribudo protegido, acessível dentro da classe e por instância herdada.
        protected decimal saldo;

        //abstract - vai ser implementado nas classes herdadas.
        public abstract void Credita(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é: " + saldo);
        }
    }
}