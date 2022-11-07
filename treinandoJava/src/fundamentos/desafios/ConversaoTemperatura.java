package fundamentos.desafios;

public class ConversaoTemperatura 
{
	public static void main(String[] args) 
	{
		//Converter temperatura Fahrenheit para Celsius
		double celsius;
		double fahrenheit;
		double formula;
		
		fahrenheit = 86;
		formula = (fahrenheit-32)/1.8;
		
		System.out.println("Conversao Temperatura fahrenheit para celsius:");
		System.out.println("fahrenheit = " + fahrenheit);
		System.out.println("celsius = " + formula);
		
	}
}
