package fundamentos;

public class AreaCircunferencia 
{
	//treinar variavel e constante
	//Entrada - raio, pi
	public static void main(String[] args)
	{
		//int raio = 3;
		double raio = 3.4;
		//double pi = 3.14159; 
		final double PI = 3.14159; //o valor de pi não muda, usar constante usando final.
		double area = PI*raio*raio;		
		//resultado da circunferencia
		//System.out.println(pi*raio*raio);
		System.out.println("area 1 = " + area);
		
		//Outro valor de raio
		raio = 10;
		area = PI*raio*raio;		
		
		//melhorando o codigo
		System.out.println("area 2 = " + area);		
		
		
	}

}
