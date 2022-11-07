package dio.controle.fluxo.condicional.simples;

public class CaixaEletronico 
{
	

	public static void main(String[] args) 
	{
		double saldo = 30.00;
		double valorSolicitado = 5.00;
		
		//controle de fluxo simples com expressão positiva
		if(valorSolicitado < saldo)
		{
			saldo = saldo - valorSolicitado;
			
		}
		
		System.out.println("Saldo atual: " + saldo);
	}

}
