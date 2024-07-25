using System;
using System.Net.WebSockets;

namespace Projeto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantidade mínimas de peças: ");
            string? entrada1 = Console.ReadLine();
            int qnt1;
            while (!int.TryParse(entrada1, out qnt1))
            {
                Console.WriteLine("Quantidade invalida. Tente novamente!");
                entrada1 = Console.ReadLine();

            }

            Console.WriteLine("Digite quantidade máxima de peças: ");
            string? entrada2 = Console.ReadLine();
            int qnt2;
            while (!int.TryParse(entrada2, out qnt2))
            {
                Console.WriteLine("Quantidade invalida. Tente novamente!");
                entrada2 = Console.ReadLine();

            }

            int media = Media(qnt1, qnt2);
            Console.WriteLine($"A media de {qnt1} e {qnt2} é: {media}");

        }

        static int Media(int qnt1, int qnt2)
        {
            return (qnt1 + qnt2) / 2;
        }
    }

}
