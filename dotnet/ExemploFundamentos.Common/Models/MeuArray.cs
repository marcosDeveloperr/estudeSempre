using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    //Esse T é type
    //classe genérica - sem tipo colocando <>
    public class MeuArray<T>
    {
        private static int capacidade = 10;
        private int contador = 0;

        //tem um array sem tipo
        private T[] array = new T[capacidade];

        //Parâmetro é do tipo genérico.
        public void AdicionarElementoArray(T elemento)
        {
            //Pois é a capacidade do array
            //controle que não adicionar mais que 10 elementos.
            if(contador + 1 <11)
            {
                array[contador] = elemento;
            }
            contador++;

        }

        //obter o elemento no array com base na posição
        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

    }


    //classe para manipular um array
    // public class MeuArray
    // {
    //     //criando um array inteiro de 10 posições
    //     private int[] array = new int[10];
    // }

    
}