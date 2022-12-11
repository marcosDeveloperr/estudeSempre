using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Models
{
    public class Calculadora
    {
        //método somar
        public void somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x+y}");
        }
        public void subtracao(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x-y}");
        }
        public void multiplicacao(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x*y}");
        }
        public void divisao(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x/y}");
        }
    }
}