using DSR_Globo.Services;
using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Informe o código Morse.");
            return;
        }

        var service = new MorseTranslatorService();
        var resultado = service.Translate(args[0]);
        Console.WriteLine($"Resultado: {resultado}");        
    }
}
