using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models.ExemploPOO.Interfaces
{
    //somar, subtrair, multiplicar e dividir
    //Tendos as 4 operações básica de uma calculadora
    public interface ICalculadora
    {
        //Por padrão subtende que são públicos
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2);

    }
}