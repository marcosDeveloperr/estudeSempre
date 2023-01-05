// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using ExemploFundamentos.Common.Models.ExemploPOO;

ContaCorrente c1 = new ContaCorrente(123, 1000);
//c1.saldo - erro porque saldo é privado
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();



//Polimorfismo - método Apresentar()
Aluno a1 = new Aluno();
a1.Nome = "Marcos";
a1.Email = "emailTal@gmail.com";
a1.Idade = 34;
a1.Nota = 10; //exclusiva da classe aluno
a1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Eduardo";
p1.Idade = 30;
p1.Salario = 1000;
p1.Apresentar();



































// Pessoa p1 = new Pessoa();
// p1.Nome = "Leonardo";
// p1.Idade = 20;
// p1.Apresentar();