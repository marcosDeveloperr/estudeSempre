package dio.controle.fluxo.condicional.simples;

import javax.swing.JOptionPane;

public class UncheckedException 
{
	public static void main(String[] args)
	{		
		//Entrada primeiro numero, numerador, através da caixa de dialogo.
		//Entrada segundo número, denominador, através da caixa de dialogo.
		//realizar a divisão de dois números inteiros.
		//Saida do resultado da divisão.
		
		String numerador = JOptionPane.showInputDialog("Numerador");
		String denominador = JOptionPane.showInputDialog("Denominador");
		
		int resultado = dividir(Integer.parseInt(numerador),Integer.parseInt(denominador));
		System.out.println("resultado da divisão: " + resultado);
		
	}
	
	public static int dividir(int a, int b)
	{
		return a/b;
	}
}
