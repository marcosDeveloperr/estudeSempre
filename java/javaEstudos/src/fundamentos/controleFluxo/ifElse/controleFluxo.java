package fundamentos.controleFluxo.ifElse;

import javax.lang.model.util.ElementScanner14;

/**Controle de Fluxo
 * 
 * Capacidade de direcionar o fluxo de execução do código.
 * 
 * *****Decisão*****
 * Avalia condição booleana ou variavel direcione o fluxo de execução.
 * 
 * if //se 
 * if-else  //se - senao
 * if-else-if
 * 
 * switch //escolha - ex: variavel case 1 breack case 2 breack ...default break
 * variavel: byte, short, char, int , Enum, String
 * observao int , Enum e String são os mais usados. Mais organizados, facil ...
 * boas práticas: tem apenas uma variavel ou valor exato usa o switch
 * if para mais de uma variavel envolvida, resultados booleanos...
 * Evitar efeito flecha dos if's
 * Evitar muitos if's aninhados
 * 
 * operador ternario //condicao ? true : false
 * 
 * 
 * 
 * *****Repetição*****
 * 
 * for
 * while  
 * do while
 * 
 * 
 * 
 * *****Interrupção*****
 * break
 * continue
 * return
 * 
 * */ 

public class controleFluxo
{
    public static void main(String[] args) 
    {
        ifFlecha();
        ifSemFlecha();
        ifFerias();
    }


    private static void ifFlecha()
    {
        int mes = 8;

        if(mes == 1)
        {
            System.out.println("JANEIRO");
        }
        else
        {
            if(mes == 2)
            {
                System.out.println("FEVEREIRO");
            }
            
            else
            {
                if(mes == 3)
                {
                    System.out.println("MARÇO");
                }
                else
                {
                    if(mes == 4)
                    {
                        System.out.println("ABRIL");
                    }
                    else
                    {
                        if(mes == 5)
                        {
                            System.out.println("MAIO");
                        }
                        else
                        {
                            if(mes == 6)
                            {
                                System.out.println("JUNHO");
                            }
                            else
                            {
                                if(mes == 7)
                                {
                                    System.out.println("JULHO");
                                }
                                else
                                {
                                    if(mes == 8)
                                    {
                                        System.out.println("AGOSTO");
                                    }
                                    else
                                    {
                                        if(mes == 9)
                                        {
                                            System.out.println("SETEMBRO");
                                        }
                                        else
                                        {
                                            if(mes == 10)
                                            {
                                                System.out.println("OUTUBRO");
                                            }
                                            else
                                            {
                                                if(mes == 11)
                                                {
                                                    System.out.println("NOVEMBRO");
                                                }
                                                else
                                                {
                                                    if(mes == 12)
                                                    {
                                                        System.out.println("DEZEMBRO");
                                                    }
                                                    else
                                                    {
                                                        System.out.println("Escolheu numero fora do intervalo de 1 a 12");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        
                    }
                }
            }
            
        }
    }    

    private static void ifSemFlecha()
    {
        int mesEscolhido = 3;

        if(mesEscolhido == 1)
        {
            System.out.println("JANEIRO");
        }
        else if(mesEscolhido == 2)
        {
            System.out.println("FEVEREIRO");
        }
        else if(mesEscolhido == 3)
        {
            System.out.println("MARÇO");
        }
        else if(mesEscolhido == 4)
        {
            System.out.println("ABRIL");
        }
        else if(mesEscolhido == 5)
        {
            System.out.println("MAIO");
        }
        else if(mesEscolhido == 6)
        {
            System.out.println("JUNHO");
        }
        else if(mesEscolhido == 7)
        {
            System.out.println("JULHO");
        }
        else if(mesEscolhido == 8)
        {
            System.out.println("AGOSTO");
        }
        else if(mesEscolhido == 9)
        {
            System.out.println("SETEMBRO");
        }
        else if(mesEscolhido == 10)
        {
            System.out.println("OUTUBRO");
        }
        else if(mesEscolhido == 11)
        {
            System.out.println("NOVEMBRO");
        }
        else if(mesEscolhido == 12)
        {
            System.out.println("DEZEMBRO");
        }
        else 
        {
            System.out.println("Numero escolhido fora do intervalo.");
        }
    }

    private static void ifFerias()
    {
        String mesFerias = "Março";

        //não fica legal fazer com if, melhor seria com switch
        if(mesFerias == "Março" || mesFerias == "Abril" || mesFerias == "Maio")
        {
            System.out.println("Fériassss....partiu.");
        }
    }


}
