using System;

namespace Coding_Cahllenge_Gabriel_Cadena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Simulator Old Phone Pad ===");
            Console.WriteLine("Type the key sequence (use space to pause, '*' to delete, '#' to send):");
            Console.Write("Text: ");

            string entrada = Console.ReadLine()?.Trim() ?? "";

            if (!entrada.EndsWith("#"))
            {
                Console.WriteLine("!The sequence must end with '#' to send.!");
                return;
            }

            string resultado = OldPhone.OldPhonePad(entrada);

            Console.WriteLine($"\nMessage: {resultado}");
        }
    }
}
