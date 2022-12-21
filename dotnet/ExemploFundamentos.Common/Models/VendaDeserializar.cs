using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploFundamentos.Common.Models
{
    //deserializando recebendo um arquivo json convertendo em objeto.
    public class VendaDeserializar
    {
        //criando os atributos referente ao arquivo venda.json na pasta arquivos,
        //tendo os mesmo nomes.
        public int Id { get; set; }
        
        //variavel recibida do venda.json escrita Nome_Produto - estaria saindo da conversao do C# - evitar bagunçar o código
        //Entra entra o ATRIBUTO   [JsonProperty("Nome_Produto")] 
        //public string Nome_Produto { get; set; }
       
        [JsonProperty("Nome_Produto")] //estaria escrito em venda.json
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}