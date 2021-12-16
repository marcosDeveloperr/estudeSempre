package fundamentos.metodos;

/**Metodos
 *  sub-rotina da classe
 *  defina um comportamento da classe
 * 
 * - Criação:
 *  visibilidade    tipo        modificador     retorno     nome (parametro) exceçoes corpo
 *  public          concreto    static          void
 *  protecte        abstrato    final
 *  private
 * 
 * - Utilizacao
 *  nomeDaClasse.nomeDoMetodo()
 *  nomeDoObjeto.nomeDoMetodo()
 * 
 *  - Assinatura
 *  Forma de identificar unicamente o metodo
 *  Assinatura  = nome + parametro
 * 
 *  - Passagem por parametro
 *  por valor (copia)
 *  por referencia (endereco)
 */
public class Metodos 
{
    double bonus = 1.0d;

    //metodo por passagem por parametro - valor (copia)
    //dentro do metodo o valor do bonus é atualizado, mas colocando o System.out.println 
    //fora do metodo continua tendo o valor 1.0d
    //Isso é passagem por parametro por valor(copia)
    
    public void bonusNota(double bonus)
        {
            bonus = bonus + 5.0d;
            System.out.println("Dentro do metodo o valor do bonus: " + bonus);
        }
   
    public static void main(String[] args)
    {
       
        Metodos met = new Metodos();
        met.bonusNota(6.0);
      
        
    }    
    
}
