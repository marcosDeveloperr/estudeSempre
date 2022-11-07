package dio.controle.fluxo.condicional.simples;

public class PinturaDesejada 
{
	public static void main(String[] args) 
	{
		int opcaoDesejada = 4;
		
		if(opcaoDesejada == 1)
		{
			System.out.println("Pintura Vermelha");
		}
		//condicional encadeada varias opções
		else if(opcaoDesejada == 2)
		{
			System.out.println("Pintura Branca");
		}
		else if(opcaoDesejada == 3)
		{
			System.out.println("Pintura Verde");
		}
		else if(opcaoDesejada == 4)
		{
			System.out.println("Pintura Amarela");
		}
		
		else
		{
			System.out.println("Pintura Preta");
		}
		
	}
}
