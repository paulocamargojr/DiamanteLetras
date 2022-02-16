using System;

namespace DiamanteLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alfabetoArray = alfabeto.ToCharArray();
            Console.WriteLine("Insira uma letra: ");
            string letra = Console.ReadLine();
            int linhas = alfabeto.IndexOf(letra);
            int espacos = linhas, espacosMeio = 0;
            for (int i = 0; i < linhas; i++)
            {
                for (int j = espacos; j > 0; j--)
                {
                    Console.Write(" ");
                }
                Console.Write(alfabetoArray[i]);
                for (int j = 0; j < espacosMeio; j++)
                {
                    Console.Write(" ");
                }
                if(i > 0)
                {
                    Console.Write(alfabetoArray[i]);
                }
                Console.WriteLine("\n");
                espacosMeio += 2;
                espacos--;
            }
            for (int i = linhas; i >= 0; i--)
            {
                for (int j = espacos; j > 0; j--)
                {
                    Console.Write(" ");
                }
                Console.Write(alfabetoArray[i]);
                for (int j = 0; j < espacosMeio; j++)
                {
                    Console.Write(" ");
                }
                if (i > 0)
                {
                    Console.Write(alfabetoArray[i]);
                }
                Console.WriteLine("\n");
                espacosMeio -= 2;
                espacos++;
            }
            Console.ReadKey();
        }
    }
}
