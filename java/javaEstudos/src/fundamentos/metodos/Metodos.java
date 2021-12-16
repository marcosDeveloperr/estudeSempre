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
    public void bonusNota(double nota)
        {
            nota = nota + bonus;
            System.out.println("nota final com bonus 1.0: " + nota);
        }
   
    public static void main(String[] args)
    {
       
        Metodos met = new Metodos();
        met.bonusNota(6.0);
        
    }    
    
}
