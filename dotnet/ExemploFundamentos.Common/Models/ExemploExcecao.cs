using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class ExemploExcessao
    {
        //Métodos em cascata
        public void Metodo1()
        {
            Metodo2();

        }
        public void Metodo2()
        {
            
                Metodo3();           
            
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            //throw - joga uma excessão para cima, buscando algum tratamento tray catch, caso não encontra 
            //executa a nova exceção.
            throw new Exception("Ocorreu uma exceção");
        }
    }
}