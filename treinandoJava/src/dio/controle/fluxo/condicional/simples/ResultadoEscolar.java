package dio.controle.fluxo.condicional.simples;

public class ResultadoEscolar 
{
	public static void main(String[] args) 
	{	
		double nota = 10.00;
		
		//fluco condicional composto com mais de uma verificação
		if(nota>=7.00)
		{
			System.out.println("Aprovado");
			
		}
		else
		{
			System.out.println("Reprovado");
		}
		
	}
}
