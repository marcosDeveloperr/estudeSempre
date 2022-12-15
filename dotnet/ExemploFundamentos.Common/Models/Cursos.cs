using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Cursos
    {
        public string nome { get; set; }
        //lista(coleção) contendo nenhum ou varios alunos
        public List<Pessoa> Alunos { get; set; }

        public void adicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno); //metodo 
        }
        //quantide de alunos da lista Alunos
        public int obterQuantidadeDeAlunosMatriculados()
        {
            int quantidadeAlunos = Alunos.Count; //count é propriedade da lista
            return quantidadeAlunos;
        }
        //public void removerAluno(Pessoa aluno)
        public bool removerAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
            //melhorar o codigo, troco o void por bool
            return true; //informando que foi removido o aluno da lista com retorno true.
            //return Alunos.Remove(aluno); //o método Remove retorna um booleano.

        }
        public void ListarAlunos()
        {   //Apareça a numeração de ordem dos alunos incluido na lista
            for (int i = 0; i < Alunos.Count; i++)//Count porque Alunos é uma lista, funciona como length 
            {
                string textoVisualizadoConsole = "Nº " + i + " "+ Alunos[i].nomeCompleto;
                Console.WriteLine(textoVisualizadoConsole);
            }
            


            // foreach(Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine(aluno.nomeCompleto);
            // }
        }

    }
}