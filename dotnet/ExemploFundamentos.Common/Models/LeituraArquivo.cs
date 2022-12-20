using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class LeituraArquivo
    {
        //metodo para ler um arquivo usando Tupla
        public (bool sucesso, string[]linhas, int quantidadeLinha)LerAquivoTupla(string caminhoArquivo) 
        {
            try
            {
                //abrindo, lendo o arquivo e retornando uma matriz de string contendo todas as linhas do arquivo
                string[] linhasRetornadas = File.ReadAllLines(caminhoArquivo);
                return (true, linhasRetornadas, linhasRetornadas.Count());
                
            }
            catch(Exception)
            {

                return (false,new string[0],0);
            }
        }
    }
}