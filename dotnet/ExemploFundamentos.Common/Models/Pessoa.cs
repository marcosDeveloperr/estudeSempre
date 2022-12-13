using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    /// <summary>
    /// Representa uma pessoa física
    /// </summary>
    public class Pessoa
    {
        //validando os get e set na propriedade nome
        //criando um campo de armazenamento

        //protegido e maninupalado apenas por essa classe de forma direta. 
        //tendo que utilizar o get e set
        private string _nome; 

        //validação dos get e set
        public string Nome 
        {         
            get
            {
                return _nome.ToUpper();//campo com letras maiúsculas.
            } 
            set
            {
                //Validação é não aceitar campo vazio e encerrar o programa.
                if(value == "") 
                {
                    //uma excessão quando o argumento não é valido, que no caso é campo vazio.
                    throw new ArgumentException("O campo nome não pode ser vazio");
                }
                _nome = value; //valor não sendo vazio atribui ao campo _nome

            }        
        }
        public int Idade { get; set; }

        public void Apresentar()
        {
            //implicitamente (...por baixo dos panos.) coloca uma propriedade entre  { } estar chamando um método get
            Console.WriteLine($"Olá meu nome {Nome} e minha idade {Idade}"); 
        }
    }
}