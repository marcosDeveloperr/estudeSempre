package dio.oo.estruturaBasica;

//1.Criar uma classe carro
//2.Criar os atributos: cor, modelo e capacidade do tanque
//3.Criar métodos Get e set 
//4.criar método, calcular o valor total para encher o tanque. Deve receber 
//como parâmetro o valor da gasolina. 
//5.Fazer duas sobrecargas do construtor.

public class Carro //classe criada 
{
	String cor;
	String modelo;
	int capacidadeTanque;  //atributos criados
	
	//Construtor aqui
	Carro() //Construtor mais simples
	{
		
	}
	Carro(String cor, String modelo, int capacidadeTanque) //construtor
	{
		this.cor = cor;
		this.modelo = modelo;
		this.capacidadeTanque = capacidadeTanque;
	}
	//acima com os dois construtor temos a sobrecarga
	
	
	void setCor(String cor) //void, adicionar o valor no atributo cor
	{
		this.cor = cor;
	}
	String getCor()
	{
		return cor;
	}
	
	void setModelo(String modelo)
	{
		this.modelo = modelo;
	}
	
	String getModelo()
	{
		return modelo;
	}
	
	void setCapacidadeTanque(int capacidadeTanque)
	{
		this.capacidadeTanque = capacidadeTanque;
	}
	
	int getCapacidadeTanque()
	{
		return capacidadeTanque;
	}
	
	//calcular o valor total para encher o tanque
	double totalValorTanque(double valorCombustivel)
	{
		return capacidadeTanque*valorCombustivel;
	}
	
	
	

}
