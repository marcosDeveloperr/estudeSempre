// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Testando o projeto console...");

using ExemploFundamentos.Common.Models;

//Exceções e Coleções

try
{
    string[] linha = File.ReadAllLines("arquivos/arquivoLeitura.txt"); //caminho do arquivos a ser lido.
    //string[] linha = File.ReadAllLines("arquivos/pasta/arquivoLeitura.txt"); //diretorio não encontrado do arquivos a ser lido.
    //string[] linha = File.ReadAllLines("arquivos/pasta/_arquivoLeitura.txt"); //caminho do arquivos a ser lido.

    foreach (var linhasDoAquivo in linha)
    {
        Console.WriteLine(linhasDoAquivo);
    }
}
catch(FileNotFoundException e)
{
    Console.WriteLine($"Ocorreu um erro no arquivo. Arquivo Não encontrado. {e.Message}");
}
catch(DirectoryNotFoundException e)
{
    Console.WriteLine($"Ocorreu um erro no arquivo. Diretório não encontrado. {e.Message}");
}
catch(Exception e)
{
    //informa a mensagem e o motivo do erro.
    Console.WriteLine($"Ocorreu uma exceção genérica {e.Message}");
}
Console.WriteLine("o Programa exibiu o errou, porém continuou executando o código");































//Desafios de Código Básico 
//1. entrada de um numero, por exemplo 234
//2. Multiplicar por cada digito do número de entrada = 2 * 3 * 4 = 24
//3. somar por cada digito do número de entrada 2 + 3 + 4 = 9
//4. Subtração do resultado da multiplicação pela soma 24 - 9 = 15
//5. Saída é 15


//entrada é string sendo convertida para inteiro
// int numeroDigitado = Convert.ToInt32(Console.ReadLine());
// int soma = 0; int multiplicacao = 1; int saida = 0;


// while(numeroDigitado>0)
// {
//     //1234
//     int ultimoDigito = numeroDigitado % 10; //sempre pego o ultimo digito
//     soma = soma + ultimoDigito; //somando os ultimos digitos
//     multiplicacao = multiplicacao * ultimoDigito;
//     numeroDigitado = numeroDigitado / 10; //123
//     saida = multiplicacao - soma;

// }
// Console.WriteLine(soma);
// Console.WriteLine(multiplicacao);
// Console.WriteLine(saida);

//Desafio

// class DIO {

// static void Main(string[] args){

//         int n = int.Parse(Console.ReadLine());
//         int p = 1, s = 0;
//         while (n > 0){
//              int l = n % 10; //pegando o ultimo numero
// // TODO: Crie as outras condições necessárias para a resolução do desafio:
//              s += l; //somando os ultimos numeros
//              p *= l;
//                   ;
//              n /=  10;
//            }

//            Console.WriteLine(p-s);
//         }
//     }


//     //Terceiro desafio - Divisores
//     class Solution {
//     public static void Main(string[] args)
//     {   //2
//         int n = int.Parse(Console.ReadLine()); //numero inteiro
//         int count = 0;


//         for (int i = 1; i <= n; i++) {
// // TODO: Crie as outras condições necessárias para a resolução do desafio:
//             if (n % i == 0) 
//             {
//                 count++;
//             }
//             if (count > n) 
//             {

//                 Console.WriteLine("false");
//             }
//         }
//          Console.WriteLine(count == 3);
//     }
// }





































// DateTime data = DateTime.Now;
// Console.WriteLine(data); //data e horário atual
// Console.WriteLine(data.ToShortDateString());//data
// Console.WriteLine(data.ToShortTimeString());//hora

// DateTime date = DateTime.Parse("17/04/2022 18:00"); //Convertendo uma string em Datetime
// Console.WriteLine(date);

// //Passa um string com data e hora
// string dataString = "2022-04-17 18:00";
// // DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime data);
// // Console.WriteLine(data);



























// decimal valorMonetario = 1582.40M; //M maiusculo exigencia da variavel decimal.
// //Console.WriteLine(valorMonetario);//Não informa qual moeda é esse valor monetário.
// Console.WriteLine($"{valorMonetario:C}"); //informando que a moeda é real referencia na configuração do meu sistema


// //Personalisando valor monetario
// Console.WriteLine(valorMonetario.ToString("N2")); //apenas numeros


// //Porcentagem
// double pocentagem = .3421;
// Console.WriteLine(pocentagem.ToString("P"));//colocar o numero em porcentagem

// //nuemro
// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));






























// //1. criando 3 objetos pessoas com 
// Pessoa p20 = new Pessoa("Patricia","França");
// Pessoa p30 = new Pessoa(nome: "Rebeca", sobreNome: "Italia");
// Pessoa p40 = new Pessoa();

// //2. atribuindo valores as propriedades nome e sobreNome aos objetos pessoa
// //p20.Nome = "Patricia"; utilizando o segundo construtor que recebe o parâmetro nome e sobreNome (linha 8)
// //p20.sobreNome = "França";
// //p30.Nome = "Rebeca";
// //p30.sobreNome = "Italia";
// p40.Nome = "Gabriella";
// p40.sobreNome = "Brasil";

// //3. Criar um curso com o nome: curso de inglês
// Cursos cursoDeIngles = new Cursos();
// cursoDeIngles.nome = "Curso de Inglês";

// //4. Cria uma lista de alunos para o curso de inglês
// cursoDeIngles.Alunos = new List<Pessoa>();
// cursoDeIngles.adicionarAluno(p20);//adicionando o aluno 
// cursoDeIngles.adicionarAluno(p30);
// cursoDeIngles.adicionarAluno(p40);

// //5. Lista os alunos matriculados no curso de inglês
// cursoDeIngles.ListarAlunos();






























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


//Pessoa p10 = new Pessoa(); //classe pertecendo a outro projeto ExemploFundamentos.Common pertecendo a solution Pottencial .Net.sln
//p10.Nome = "marcos";
//p10.Nome = "Marcos";
//p10.sobreNome = "Portugal";
// p10.Idade = 30;
//p10.Apresentar();

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