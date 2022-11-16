package dio.oo.estruturaBasica;

public class RodarAplicacao 
{
	public static void main(String[] args) 
	{
		/*
		 * 1.  Criar objetos carro;
		 * 2.  Usar o método set para atribuir valores aos atributos;
		 * 3.  Usar o método get para exibir os valores dos atributos;
		 * 4.  Enviar mensagem para o cálculo do total para encher o tanque;
		 * */
		
		//criando objetos - carro
		Carro carro1 = new Carro(); 
		Carro carro2 = new Carro();
		
		carro1.setCor("Azul");
		carro1.setModelo("BMW Serie 3");
		carro1.setCapacidadeTanque(59);
		
		
		System.out.println("carro 1 - Cor: " + carro1.getCor());
		System.out.println("carro 1 - Modelo: " + carro1.getModelo());
		System.out.println("carro 1 - Capacidade do Tanque: " + carro1.getCapacidadeTanque());
		System.out.println("carro 1 - Total valor encher o tanque: " + carro1.totalValorTanque(5.00));
	}

}
