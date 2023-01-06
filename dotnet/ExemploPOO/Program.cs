// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using ExemploFundamentos.Common.Models.ExemploPOO;
using ExemploFundamentos.Common.Models.ExemploPOO.Interfaces;


//praticando interface

//classe calculadora implementa todos os métodos da interface ICalculadora.
//É contrato, deve ser implementada por classe.
//interface não é instanciada
// ICalculadora cal = new ICalculadora();

 ICalculadora cal = new Calculadora();
Console.WriteLine(cal.Multiplicar(3, 9));






































// //Porque a classe Pessoa tem um construtor com essa exigência.
// //Ao criar o objeto tem a exigência de colocar o parâmetro nome
// Pessoa p1 = new Pessoa("Francisco");


// //colocando um parâmetro nome
// //Aluno classe que herda de Pessoa tem essa exigência de criar um objeto 
// Aluno a1 = new Aluno("Antonia");
// a1.Apresentar();


// //agora podendo criar um objeto sem parâmetro.
// //colocando mais um construtor default nas classe aluno, pessoa e professor
// Professor prof = new Professor();



































// Corrente corrente1 = new Corrente();
// corrente1.Creditar(500);
// corrente1.ExibirSaldo();
































// ContaCorrente c1 = new ContaCorrente(123, 1000);
// //c1.saldo - erro porque saldo é privado
// c1.ExibirSaldo();
// c1.Sacar(500);
// c1.ExibirSaldo();



// //Polimorfismo - método Apresentar()
// Aluno a1 = new Aluno();
// a1.Nome = "Marcos";
// a1.Email = "emailTal@gmail.com";
// a1.Idade = 34;
// a1.Nota = 10; //exclusiva da classe aluno
// a1.Apresentar();

// Professor p1 = new Professor();
// p1.Nome = "Eduardo";
// p1.Idade = 30;
// p1.Salario = 1000;
// p1.Apresentar();



































// Pessoa p1 = new Pessoa();
// p1.Nome = "Leonardo";
// p1.Idade = 20;
// p1.Apresentar();