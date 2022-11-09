package dio.controle.fluxo.condicional.simples;

import java.util.Random;

public class ExemploDoWhile 
{
	/*
	 * Joaozinho resolveu ligar para o seu amigo dizendo que hoje se entupiu de comer docinhos..
	 * */
	public static void main(String[] args)
	{
		//pegou o telefone e discou o numero
		System.out.println("Discando...");
		
		do 
		{
			System.out.println("Telefone tocando...");
		}
		while(tocando());
		{
			System.out.println("Alô");
		}
	}
	private static boolean tocando()
	{
		boolean atendeu = new Random().nextInt(2)==1;
		System.out.println("atendeu: " + atendeu);
		return !atendeu; //não atendeu - falso
	}
}
