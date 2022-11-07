package dio.controle.fluxo.condicional.simples;

public class PlanoOperadora 
{

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		String plano = "M";
		
		if(plano == "B")
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
		}

	}

}
