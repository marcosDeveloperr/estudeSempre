package fundamentos.array;

import java.util.Scanner;

public class ArrayConsoante
{
    public static void main(String[] args) 
    {
        //6 caracteres
        String[] consoant = new String[6];
        int quantidadeConsoant = 0;
        int contador = 0;
        Scanner entrada = new Scanner(System.in);
        System.out.println("informe 6 caracteres: ");

        do{            
            String texto = entrada.nextLine();

            if( !(texto.equalsIgnoreCase("a") |
                  texto.equalsIgnoreCase("e") |
                  texto.equalsIgnoreCase("i") |
                  texto.equalsIgnoreCase("o") |
                  texto.equalsIgnoreCase("u"))
            ){
                consoant[contador] = texto;
                quantidadeConsoant++;
            }

            contador++;           


        }while(contador<consoant.length);
        //do zero até 6 , tamanho do array.



    }    
}
