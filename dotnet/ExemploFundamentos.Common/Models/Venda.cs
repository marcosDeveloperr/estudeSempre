using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ExemploFundamentos.Common.Models
{
    //O cliente pediu os dados das vendas convertido em json
    public class Venda
    {
         //Método Construtor
        public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        {
            this.Id = id;
            this.Produto = produto;
            this.Preco = preco;
            this.DataVenda = dataVenda;
        }

        //Propriedades (atributos)
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        
        //Aceita valor null
        //Colocar a propriedade ( ? ) logo depois do tipo decimal
        //Não pode ser decimal, porque não aceita null
        //adicionada no arquivo venda.json na pasta arquivos/
        //public decimal Desconto { get; set; }
        public decimal? Desconto { get; set; }

       

    }
    
}