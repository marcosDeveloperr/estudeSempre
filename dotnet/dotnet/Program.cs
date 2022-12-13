// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Testando o projeto console...");

using ExemploFundamentos.Common.Models;
//Array
// int [] numeros = new int[5];
// numeros[0] = 10;
// numeros[1] = 20;
// numeros[2] = 30;
// numeros[3] = 40;
// numeros[4] = 50;


// for(int contador = 0; contador<numeros.Length; contador++)
// {
//     Console.WriteLine($"Posição {contador} - {numeros[contador]}");
// }

// //int contadorforeach = 0;
// foreach(int valor in numeros)
// {
//     Console.WriteLine(valor);
//     //Console.WriteLine($"Posicao {contadorForeach} - {valor}");
//     //contadorForeach++
// }

// Array.Resize(ref numeros, numeros.Length * 2);//pegando o tamanho do array e multiplicando por 2, dobrando o tamanho do array.
// foreach(int papaleguas in numeros)
// {
//     Console.WriteLine(papaleguas);
// }

// //Copiar Array
// int[] arrayRecebeDados = new int[numeros.Length * 2];

// Array.Copy(numeros,arrayRecebeDados,2);//copiando dois elementos. Poderia ser arrayRecebeDados.length
// foreach(int arrayCopiado in arrayRecebeDados)
// {
//     Console.WriteLine(arrayCopiado);
// }


 Pessoa p10 = new Pessoa(); //classe pertecendo a outro projeto ExemploFundamentos.Common pertecendo a solution Pottencial .Net.sln
 //p10.Nome = "marcos";
 p10.Nome = "";
 p10.Idade = 30;
 p10.Apresentar();

// // Menu Interativo
// bool condicao = true; 
// while(condicao)
// {
//     Console.WriteLine("Digite uma das opções do Menu");
//     Console.WriteLine("1 - Cadastrar clientes");
//     Console.WriteLine("2 - Buscar Cliente");
//     Console.WriteLine("3 - Apagar Cliente");
//     Console.WriteLine("4 - Encerrar");
//     int opcao = Convert.ToInt32(Console.ReadLine());

//     switch(opcao)
//     {
//         case 1:
//         Console.WriteLine("opção escolhida - 1 cadastro de cliente");
        
//         break;

//         case 2:
//         Console.WriteLine("Opão escolhida - 2 Buscar Cliente");
       
//         break;
        
//         case 3:
//         Console.WriteLine("Opção escolhida - 3 Apagar Cliente");
      
//         break;

//         case 4:
//         Console.WriteLine("Opção escolhida - 4 Encerrar");
//         condicao = false;
//         break;

//         default:
//         Console.WriteLine("Opção inválida");
//         break;
//     }

// }
//***** Estrutura de Repetição - Do While

// Console.WriteLine("Informe números para serem somandos. Precione 0 para parar");
// int numero = 0;
// int soma = 0;
// int contador = 0;
// do
// {
//      numero = Convert.ToInt32(Console.ReadLine());
//      soma = soma + numero;
//      contador++;

// } while (numero != 0);
// Console.WriteLine("A soma dos numeros digitados é: " + soma);

//***** Estrutura de Repetição(laços) - while

// int numero = 5;
// int contador = 0;
// while (contador <= 10) //quanto for verdadeiro
// {
//     Console.WriteLine($"{contador} - {numero} x {contador} = {numero*contador}");
//     contador++; //contador + 1
//     if(contador == 5)
//     {
//         break; //interromper o laço
//     }
// }


//***** Estrutura de Repetição(laços) - For
// int numero = 10;
// for (int i =0; i <= numero; i++)
// {
//     Console.WriteLine($"{numero} x {i} = {numero * i}");
// }
    



//usando os métodos da classe Calculadora
// Calculadora cal= new Calculadora();
// cal.somar(20,10);
// cal.subtracao(20,10);
// cal.multiplicacao(20,10);
// cal.divisao(20,10);
// cal.potenciacao(3,3);
// cal.seno(30);
// cal.coseno(30);
// cal.tangente(30);
// cal.raizQuadrada(4);


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