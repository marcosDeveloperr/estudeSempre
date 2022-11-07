package dio.controle.fluxo.condicional.simples;

public class SistemaMedida {

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		String sigla = "K";
		
		if(sigla == "P")
		{
			System.out.println("Tamanho Pequeno");
		}
		else if(sigla == "M")
		{
			System.out.println("Tamanho Medio");
		}
		else if(sigla == "G")
		{
			System.out.println("Tamanho Grande");
		}
		else
		{
			System.out.println("Tamanho Indefinido");
		}

	}

}
