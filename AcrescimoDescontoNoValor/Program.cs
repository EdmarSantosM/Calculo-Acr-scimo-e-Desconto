 public class Program
 {

    static void Main(string[]args)
    {
        System.Console.WriteLine("\tDigite as informações do produto ");
        System.Console.WriteLine();

        // Definindo as variáveis que receberam  os valores recebido com método ReadLine
        string descricao;
        Console.Write(" Digite a descrição do produto : ");
        descricao = Console.ReadLine();


        /* Para as variáveis valorCusto, percentual é necessário realizar a conversão utlizando Convert.ToDecimal devido  
         o valor  recebido pelo ReadLine por padrão vem como strig*/

         decimal valorCusto = 0;
         Console.Write(" Digite o valor de custo do produto informado R$");
         valorCusto = Convert.ToDecimal(Console.ReadLine());

         decimal percentual = 0;
         Console.Write($" Digite o percentual da loja {percentual}%");
         percentual = Convert.ToDecimal(Console.ReadLine());

         // Definindo variáveis para  calculo
         decimal valorVendaFinal = 0, valorDesconto = 0;

         System.Console.WriteLine();
         System.Console.WriteLine(" ------------------------------------------------------------------------ ");
         System.Console.WriteLine($" O produto informado é '{descricao}', seu valor de custo é R${valorCusto}");
         System.Console.WriteLine(" ------------------------------------------------------------------------ ");
         System.Console.WriteLine();

         // Lógica proposta
         if(valorCusto <= 250)
         {
            valorVendaFinal = (valorCusto + (valorCusto * percentual /100 ));
            {
                System.Console.WriteLine($" O valor do produto neste caso terá um acréscimo, onde o valor de  venda fina é de 'R${valorVendaFinal}'");
                System.Console.WriteLine();
                System.Console.WriteLine(" Pressione a tecla 'Enter para finalizar'");
                Console.ReadKey();
            }
         }

    }
 }