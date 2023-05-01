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

         
    }
 }