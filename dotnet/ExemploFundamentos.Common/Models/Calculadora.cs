using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
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
        public void potenciacao(int x, int y)
        {
            double potencia = Math.Pow(x,y); //cast implicido
            Console.WriteLine($"{x}^{y} = {potencia}");
        }
        public void seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180; //primeiro a divisão de PI com 180
            double seno = Math.Sin(radiano); //recebendo o angulo em radiano
            Console.WriteLine($"seno do {angulo}° = {Math.Round(seno,4)}");//arredondamento em 4 casas decimais após a vírgula
        }
        public void coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"coseno do {angulo}° = {Math.Round(coseno,4)}");
        }
        public void tangente(double angulo)
        {
            double radiano = angulo*Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"tangente do {angulo}° = {Math.Round(tangente,4)}");
        }
        public void raizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"raiz quadrada de {x} = {raiz}");
        }
    }
}