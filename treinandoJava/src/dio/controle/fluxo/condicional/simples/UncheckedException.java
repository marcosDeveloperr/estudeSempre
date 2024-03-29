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
		
		boolean continuaLoopin = true;
		do 
		{
			String numerador = JOptionPane.showInputDialog("Numerador");//colocando nome resulta uncheckedException
			String denominador = JOptionPane.showInputDialog("Denominador");
			
			try 
			{
				int resultado = dividir(Integer.parseInt(numerador),Integer.parseInt(denominador));
				System.out.println("resultado da divisão: " + resultado);
				continuaLoopin = false;
			} 
			catch (NumberFormatException e) 
			{
				//e.printStackTrace();//imprimir
				//quando acontecer exception - NumberFormatException - digitou um texto no lugar inteiro
				//informe uma mensagem pelo motivo do erro ( entrada que realizou o erro)
				JOptionPane.showMessageDialog(null, "Informe um numero inteiro: " + e.getMessage());
			}
			catch (ArithmeticException e) 
			{
				JOptionPane.showMessageDialog(null, "Denominador não poder ser zero ( 0 )");
			}
			finally 
			{
				System.out.println("chegou no finally");
			}
		} while (continuaLoopin);		
		
		System.out.println("o código continua...");
		
		
	}
	
	public static int dividir(int a, int b)
	{
		return a/b;
	}
}
