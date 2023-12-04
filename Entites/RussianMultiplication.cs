using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PushUpRazonamientoLogico.Entites;


public class RussianMultiplication
{

    public static void GetRussianMultiplication()
    {
        Console.WriteLine("Enter Multiplicador Number :");
        int Multiplicador = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Multiplicando Number :");
        int Multiplicando = int.Parse(Console.ReadLine());
        int Total = 0;
        /* Console.WriteLine(Multiplicador); */
        while (Multiplicador >= 1)
        {
            if (Multiplicador % 2 != 0)
            {
                Total += Multiplicando;
            }
            Multiplicador /= 2;
            Multiplicando *= 2;
            /* Console.WriteLine($"Multiplicador: {Multiplicador}");
            Console.WriteLine($"Multiplicando: {Multiplicando}"); */
        }
        Console.WriteLine($"Result: {Total}");
    }

}
