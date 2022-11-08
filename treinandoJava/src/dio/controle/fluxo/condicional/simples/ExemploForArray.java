package dio.controle.fluxo.condicional.simples;

public class ExemploForArray {

	public static void main(String[] args) 
	{
		// array alunos contendo 4 nomes de alunos
		// fazer um for para mostrar cada nome
		
		String alunos[] = {"francisca", "antonia", "beatriz", "gabriella"};
		
		for(int contador = 0; contador<alunos.length; contador++)
		{
			System.out.println("array" + "[" + contador + "]" + " - " + alunos[contador]);
		}
	}

}
