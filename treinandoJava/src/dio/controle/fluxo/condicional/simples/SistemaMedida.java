package dio.controle.fluxo.condicional.simples;

public class SistemaMedida {

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		String sigla = "P";
		/*
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
		}*/
		
		//aplicando o switch case..
		
		switch(sigla)
		{
			case "P":
				{
					System.out.println("Pequeno");
					break;
				}
			case "M":
				{
					System.out.println("Medio");
					break;
				}
			case "G":
				{
					System.out.println("Grande");
					break;
				}
			default:
				{
					System.out.println("Tamanho Indefinido");
				}
		}

	}

}
