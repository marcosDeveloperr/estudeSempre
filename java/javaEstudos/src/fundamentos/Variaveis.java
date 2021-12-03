package fundamentos;

    /**
     * Teoria
     * 
     * - Local de memória para armazenar valores. Tipos: Parâmetro, local, classe e
     * instância de objeto. *
     * - Não começar com números. Não pode conter espaço, palavra reservada de java
     * 
     * *****Criação*****
     * 
     * - public static tipo nome = valor
     * protected final
     * private
     * 
     * *****Operadores Lógicos*****
     * 
     * - Realiza comparações lógicas, usando operadores lógicos ou expressões
     * retornando um resultado.
     * - Tipos: Conjunção, Disjunção, Disjunção Exclusiva e Negação.
     * 
     * -Conjunção:
     * Essa operação lógica é verdadeira quando todas as expressões são verdadeiras.
     * 
     * Simbologia: &&
     * Terminologia: and (e)
     * Tabela: V && V V V e V = V
     * V && F F V e F = F
     * F && V F F e V = F
     * F && F F F e F = F
     * 
     * -Disjunção:
     * Pasta uma expressão seja verdadeira que o resultado é verdadeiro;
     * Quando ambos são falsos, o resultado é falso.
     * 
     * Simbologia: ||
     * Terminologia: or (ou)
     * Tabela: V || V V V ou V = V
     * V || F V V ou F = V
     * F || V V F ou V = V
     * F || F F F ou F = F
     * 
     * -Disjunção Exclusiva:
     * Quando as expressões são opostas o resultado é verdadeiro.
     * 
     * Simbologia: ^
     * Terminologia: xor
     * Tabela: V ^ V F
     * V ^ F V (opostos)
     * F ^ V V (opostos)
     * F ^ F F
     * 
     * Negação:
     * Simbologia: !
     * 
     * 
     * Importantes:
     * 
     * - bitwise:
     * Não são operadores lógicos.
     * 
     * Simbologia: * & e |
     * 
     * - Operadores shift
     * Simbologia: ~ , >> , >>>, <<
     * 
     */


public class Variaveis {
    
    public static void main(String[] args) {

        boolean b1,b2,b3,b4;
        boolean conjuncao, disjuncao, disjuncaoExclusiva;

        b1 = true;
        b2 = false;
        b3 = true;
        b4 = false;        

       
        conjuncao = b1 && b3;        
        disjuncao = b2 || b4;
        disjuncaoExclusiva = b4^b1; //expressoes opostas o resultado é verdadeiro

         


        System.out.println("Operador logico b1 && b2 : " + (b1 && b2));
        System.out.println("Operador logico b1 && b3 : " + conjuncao);
        System.out.println("Operador logico b2 || b3 : " + (b2 || b3));
        System.out.println("Operador logico b2 || b4 : " + disjuncao);
        System.out.println("Operador logico b4 ^ b1 : " + disjuncaoExclusiva);
        System.out.println("Operador logico b1 ^ b3 : " + (b1 ^ b3)); //falso porque os valores nao sao opostos.
    }

}
