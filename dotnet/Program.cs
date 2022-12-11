// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Testando o projeto console...");

using dotnet.Models;
//usando os métodos da classe Calculadora
Calculadora cal= new Calculadora();
cal.somar(20,10);
cal.subtracao(20,10);
cal.multiplicacao(20,10);
cal.divisao(20,10);
cal.potenciacao(3,3);


//Operador NOT 
// !

// bool choveu = true;
// bool estarTarde = true;

// if(!choveu && !estarTarde)
// {
//     Console.WriteLine("vou pedalar");
// }
// else
// {
//     Console.WriteLine("vou deixar para mais tarde pedalar...");
// }

//Operador AND &&

// bool presencaMinima = true;
// int mediaSuperior = 5;

// if(presencaMinima && mediaSuperior >= 7)
// {
//     Console.WriteLine("aprovado");
// }
// else
// {
//     Console.WriteLine("reprovado");
// }

//Operador OR || 
//pipe

// bool maiorIdade = true;
// bool autorizaçãoResponsavel = false;

// if(maiorIdade || autorizaçãoResponsavel)
// {
//     Console.WriteLine("Entrada liberada");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }

//switch case
// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();//vai pegar o que digitar no console como resposta da pergunta.

// //Melhorando com switc
// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal!");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal!");
//         break;
// }

//Melhorando o código 
// if(letra == "a" ||
//    letra == "e" ||
//    letra == "i" ||
//    letra == "o" ||
//    letra == "u")
// {
//     Console.WriteLine("vogal!");
// }
// else
// {
//     Console.WriteLine("Não é vogal!");
// }



// if(letra == "a")
// {
//     Console.WriteLine("vogal!");
// }
// else if(letra == "e")
// {
//     Console.WriteLine("vogal!");
// }
// else if(letra == "i")
// {
//     Console.WriteLine("vogal!");
// }
// else if(letra == "o")
// {
//     Console.WriteLine("vogal!");
// }
// else if(letra == "u")
// {
//     Console.WriteLine("vogal!");
// }
// else
// {
//     Console.WriteLine("Não é vogal!");
// }



// // Operador Condicional
// int estoque = 3;
// int compras = 0;
// bool possivelCompra = compras> 0 && estoque >= compras;

// Console.WriteLine("estoque: " + estoque);
// Console.WriteLine($"compras:  {compras}");
// Console.WriteLine("Foi possível realizar a compra? " + possivelCompra);
// if(compras == 0)
// {
//     Console.WriteLine("Compra inválida");
// }
// else if(possivelCompra)
// {
//     Console.WriteLine("Compra realizada com sucesso!");
// }
// else
// {
//     Console.WriteLine("Não foi possivel realizar a compra");
// }

// Ordem dos Operadores
// parênteses, expoentes, divisao, multiplicao, adição e subtração.
// double a = 4/2 + 2;  //divisão e depois a soma
// double b = 4/(2+2);  //primeira ordem é os parênteses 
// Console.WriteLine(a);
// Console.WriteLine(b);

// int inteiro = 10;
// string texto = inteiro.ToString();  //não precisando usar o Convert.ToString()
// Console.WriteLine(texto);

//Conversao de maneira segura
// string a = "15-"; //não é "15"
// int b = 1;
 //int.TryParse(a, out b);//vai dar erro em a dando saida ao a variavel b
// Console.WriteLine(b);
// Console.WriteLine("Conversao segura");

//***** cast implícito *****
// int a = int.MaxValue; //valor máximo de um inteiro
// long b = a; //mas como o valor maximo do long é mairo que o inteiro, entao cabe no long.
// Console.WriteLine(b);

//****** Converção de tipos ******
// int a = Convert.ToInt32("10");
// int c = Convert.ToInt32(null); //saída é o numero 0.  Preferivel usar o Convert dando o valor zero e continua a aplicacao...
// int b = int.Parse("5");
// Console.WriteLine("Convertendo string em inteiro: " + a);
// Console.WriteLine("Convertendo string em inteiro: " + c);
// Console.WriteLine("Convertendo string em inteiro: " + b);
// int d = int.Parse(null); //saída é um erro
// Console.WriteLine(d);

//***** Operador de Atribuição *****
// int a = 10;
// int b = 20;
// int c = a + b;
// Console.WriteLine("A soma: " + c);

// c = c + 5; //colocando mais 5 no valor de c 
//c += 5; //também poderia ser assim, somando mais 5 no valor de c
// Console.WriteLine("Valor atual c :" + c);


// DateTime dataAtual = DateTime.Now; //pegando a data atual do sistema
// Console.WriteLine(dataAtual);

// DateTime dataAtualAdicionada = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtualAdicionada); //adicionando 5 dias a data atual do sistema
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy")); //formata de data , sem horário.

// string apresentacao = "O time maior do Brasil - Flamengo";
// int quantidade = 10;
// double altura = 1.85;
// decimal preco = 7.50M; //A letra M tratando 2 casas decimais como foi adicionada o valor 
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine(quantidade);
// Console.WriteLine(altura);
// Console.WriteLine(preco);
// Console.WriteLine(condicao);


//Pessoa p1 = new Pessoa();
//p1.Nome = "Marcos";
//p1.Idade = 24;
//p1.Apresentar();