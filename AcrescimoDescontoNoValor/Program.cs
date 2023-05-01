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
         
    }
 }