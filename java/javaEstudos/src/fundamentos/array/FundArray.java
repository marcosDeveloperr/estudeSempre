package fundamentos.array;

/** Array
 *  Armazenar dados do mesmo tipo de forma sequencial.
 *  Permanece com o mesmo tamanho após ser criado.
 *  
 *  Array Unidimensional - apenas uma linha e uma coluna.
 *  Array Multidimensional - Linha e coluna
*/

/**Array inverso
 * 
 * criar um vetor com 6 numeros inteiros.
 * mostre-os na ordem inversa.
 */

public class FundArray
{
    public static void main(String[] args)
    {
        int[]numerosInteiros = {1,2,3,4,5,6};
        

        //mostra a referencia do array na memoria.
        System.out.println("array: " + numerosInteiros);

        //tamanho desse array = 6
        System.out.println(numerosInteiros.length + "\n");

        //for para pecorrer e visualizar cada elemento do array.
        for(int i = 0; i<numerosInteiros.length; i++)
        {
            System.out.println(numerosInteiros[i]);
        }   

        //usando o while
        int contador = 0;
        while(contador < numerosInteiros.length)
        {
            System.out.println(numerosInteiros[contador]);
            contador++;
        }

        //forma inversa
        for(int i = ((numerosInteiros.length)-1); i>=0; i--)
        {
            System.out.println(numerosInteiros[i]);
        }



       
    }
    
}
