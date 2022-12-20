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
        //construtor Pessoa default - sem parâmetros.
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobreNome)
        {
            //a ordem é o atribudo Nome recebe o parâmetro nome
            this.Nome = nome;
            this.sobreNome = sobreNome;
        }
        //descontruir ao que foi construido. 
        public void Deconstruct(string nome, string sobreNome)
        {
            //a ordem inversa, ou seja a variavel nome recebe a propriedade (atributo) Nome
            nome = this.Nome;
            sobreNome = this.sobreNome;

        }


        //validando os get e set na propriedade nome
        //criando um campo de armazenamento

        //protegido e maninupalado apenas por essa classe de forma direta. 
        //tendo que utilizar o get e set
        private string _nome; //Campo Protegida - Não acessiveis externamente.
        private int _idade;

        //validação dos get e set
        public string Nome 
        {
            // get
            // {
            //     return _nome.ToUpper();//campo com letras maiúsculas.
            // } 
            
            //utilizando body expressions
            get => _nome.ToUpper();//campo com letras maiúsculas.
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
        
        public string  sobreNome { get; set; }
        
        //somente get, não consegue atribuir valores, sendo apenas de leitura.
        public string nomeCompleto => $"{Nome} {sobreNome}".ToUpper();
        // {
        //     // get
        //     // {
        //     //     return _nome + sobreNome;
        //     // }
        // }
        public int Idade 
        { 
            get
            {
                return _idade;
            } 
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Idade não pode ter valor negativo");
                }
                _idade = value;
            } 
            
        }

        public void Apresentar()
        {
            //implicitamente (...por baixo dos panos.) coloca uma propriedade entre  { } estar chamando um método get
            Console.WriteLine($"Olá meu nome {nomeCompleto} e minha idade {Idade}"); 
        }
    }
}