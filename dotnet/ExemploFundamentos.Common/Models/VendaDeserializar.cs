using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    //deserializando recebendo um arquivo json convertendo em objeto.
    public class VendaDeserializar
    {
        //criando os atributos referente ao arquivo venda.json na pasta arquivos,
        //tendo os mesmo nomes.
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}