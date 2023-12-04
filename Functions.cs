using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PushUpRazonamientoLogico;

public class Functions
{

    public static byte MainMenu()
    {
        Console.Clear();
        Console.WriteLine("---- Exercise Menu ----");
        Console.WriteLine("{0, 3}", "1) Fibonnacci");
        Console.WriteLine("{0, 3}", "2) Check if a number is fibonacci");
        Console.WriteLine("{0, 3}", "3) Fibonacci number List");
        Console.WriteLine("{0, 3}", "4) Russian Multiplication");
        Console.WriteLine("{0, 3}", "5) Friendly Numbers");
        Console.WriteLine("{0, 3}", "6) Confech Votes");
        Console.WriteLine("{0, 3}", "10) Exit");
        Console.WriteLine("Enter the Menu Option: ");
        byte respMenu = byte.Parse(Console.ReadLine());
        return respMenu;
    }

    public static string VotesMenu()
    {
        Console.Clear();
        Console.WriteLine("---- Votes Menu ----");
        Console.WriteLine("{0, 3}", "A) Aceptar");
        Console.WriteLine("{0, 3}", "R) Rechazar");
        Console.WriteLine("{0, 3}", "N) Nulo");
        Console.WriteLine("{0, 3}", "B) Blanco");
        Console.WriteLine("{0, 3}", "X) No agregar mas votos");
        Console.WriteLine("Enter the Menu Option: ");
        string respMenu = Console.ReadLine();
        return respMenu;
    }

}
