package dio.controle.fluxo.condicional.simples;

import java.util.Random;

/*
 *Joãoziho recebeu R$ 50,00 de mesada e foi em uma loja de doces
 *gastar todo o seu dinheiro, logo, ENQUANTO o valor dos doces 
 *não igualar a R$ 50,00 ele foi adicionando itens no carrinho. */

public class ExemploWhile 
{	
	
	public static void main(String[] args) 
	{
		Random valoresAleatorios = new Random();
		double mesada = 50.00;
		double valorDoce = 0.00;
		
		while(mesada>0)
		{
			 valorDoce = valoresAleatorios.nextDouble(5);			
			 
			if(valorDoce>mesada)
			{
				valorDoce = mesada;
			}
			System.out.println("valor do doce: " + valorDoce + " adicionado carrinho");
			mesada = mesada-valorDoce;
		}
		System.out.println("Mesada: " + mesada);
		
		
	}
	
	
}
