package dio.controle.fluxo.condicional.simples;

import java.util.InputMismatchException;
import java.util.Locale;
import java.util.Scanner;

public class ExcecoesAboutMe 
{
	//about me "sobre mim"
	//Exceções: 
		//Não informar o nome e sobrenome;
		//o valor da idade ter um caractere  não númerico;
		//o valor da altura ter uma vírgula ao invés de ter um ponto
	
	public static void main(String[] args) 
	{
		//entrada:  nome, sobrenome, idade e altura
		//saída: exibir os dados de entrada.
		
		//criando o objeto scanner chamado entrada
		 
		 
		 try 
		 {				
			
			Scanner entrada = new Scanner(System.in).useLocale(Locale.US);
			
			//as entradas
			System.out.println("Nome:");
			String nome = entrada.next();
			
			System.out.println("Sobrenome:");
			String sobrenome = entrada.next();
			
			System.out.println("Idade");
			int idade = entrada.nextInt();
			
			System.out.println("Altura");
			double altura = entrada.nextDouble();
			
			//imprimindo as saídas dos dados digitados pelo usuário
			System.out.println("Nome: " + nome.toLowerCase() + " " + sobrenome.toLowerCase());
			System.out.println("Idade: " + idade + " anos ");
			System.out.println("Altura: " + altura + " cm ");
		 }
		 catch (InputMismatchException e) 
		 {
				System.out.println("Os campos idade e altura são numéricos");
				System.out.println("utilizando pontos ao inves de virgulas entre");
				System.out.println("as casas decimais.");
		 }	
	}
}
