package dio.controle.fluxo.condicional.simples;

public class ExemploForBreakContinue {

	public static void main(String[] args)
	{
		// utilizando o break e continue no for
		
		for(int i = 0; i<=10; i++)
		{
			if(i==7)
			{
				break; 
			}
			System.out.println("contando: " + i);
		}

	}

}
