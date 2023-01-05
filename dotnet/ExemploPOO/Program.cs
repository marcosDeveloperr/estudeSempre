// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using ExemploFundamentos.Common.Models.ExemploPOO;

ContaCorrente c1 = new ContaCorrente(123, 1000);
//c1.saldo - erro porque saldo é privado
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();



































// Pessoa p1 = new Pessoa();
// p1.Nome = "Leonardo";
// p1.Idade = 20;
// p1.Apresentar();