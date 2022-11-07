package dio.controle.fluxo.condicional.simples;

public class PlanoOperadora 
{

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		String plano = "B";
		
		/*if(plano == "B")
		{
			System.out.println("100 minutos de ligação");
		}
		else if(plano == "M")
		{
			System.out.println("100 minutos de ligação");
			System.out.println("Whats e Instagram Grátis");
		}
		else if(plano == "I")
		{
			System.out.println("100 minutos de ligação");
			System.out.println("Whats e Instagram Grátis");
			System.out.println("5Gb youtube");
		}
		else
		{
			System.out.println("Plano Indefinido");
		}*/
	
		//Refatorando o código
		switch(plano)
		{
			
			case "I":
			{
				System.out.println("5Gb youtube");
				//nao uso o break - colocando o maior plano para menor
			}
			case "M":
			{
				System.out.println("Whats e Instagram Grátis");
			}
			case "B":
			{
				System.out.println("100 minutos de ligação");
				
			}			
			
		}
		
	}

}
