package fundamentos.controleFluxo.switchEscolha;

public class Escolha 
{   

    public static void main(String[] args) {
        
        semana();
    }

    private static void semana()
    {

        String diaSemana = "segunda";

        switch(diaSemana)
        {
            case "segunda":
            System.out.println(1);
            break;

            case "terça":
            System.out.println(2);
            break;

            case "quarta":
            System.out.println(3);
            break;

            case "quinta":
            System.out.println(4);
            break;

            case "sexta":
            System.out.println(5);
            break;

            case "sabado":
            System.out.println(6);
            break;

            case "domingo":
            System.out.println(7);
            break;

            default:
            System.out.println("nenhum dia da semana.");
            break;
        }

    }
    
    
}
