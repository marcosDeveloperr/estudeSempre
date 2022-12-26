using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    
    public static class IntExtensions
    {
        //Ex int numero = 10; Então ao utilziar numero.EhPar() utiliza o valor 10 como parâmetro.
        //Quando Colocamos this int porque utilizamos o próprio valor como parâmetro.
        //método extensão para evitar duplicamento do codigo de verificar se é par ou ímpar.
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }    
    }
}