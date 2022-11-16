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
		Carro carro1 = new Carro(); //construtor mais simples
		Carro carro2 = new Carro("cinza","Mercedes-Benz Class C",66); //utilizando a sobrecarga
		
		//adicionando os valores nos atributos
		carro1.setCor("Azul");
		carro1.setModelo("BMW Serie 3");
		carro1.setCapacidadeTanque(59); 
		
		
		System.out.println("carro 1 - Cor: " + carro1.getCor());
		System.out.println("carro 1 - Modelo: " + carro1.getModelo());
		System.out.println("carro 1 - Capacidade do Tanque: " + carro1.getCapacidadeTanque());
		System.out.println("carro 1 - Total valor para encher o tanque: " + carro1.totalValorTanque(5.00) + "\n"); //quebra de linha
		
		System.out.println("Carro 2 - Cor: " + carro2.getCor());
		System.out.println("Carro 2 - Modelo: " + carro2.getModelo());
		System.out.println("Carro 2 - Capacidade do Tanque: " + carro2.getCapacidadeTanque());
		System.out.println("Carro 2 - Total valor para encher o tanque: " + carro2.totalValorTanque(5.46));
		
	
	}

}
