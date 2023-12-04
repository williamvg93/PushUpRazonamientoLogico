using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PushUpRazonamientoLogico.Entites;

public class Fibonnacci
{

    public static int CalNumFibo()
    {
        Console.WriteLine("Enter one Number :");
        int numFibo = int.Parse(Console.ReadLine());
        Console.Clear();

        int PrevVal = 1;
        int PrevNum = 0;
        int sumNum = 0;
        for (int i = 1; i < numFibo; i++)
        {
            sumNum = PrevNum + PrevVal;
            PrevNum = PrevVal;
            PrevVal = sumNum;
        }
        return sumNum;
    }

    public static string VerNumFibo()
    {
        Console.WriteLine("Enter one Number :");
        int numFibo = int.Parse(Console.ReadLine());
        Console.Clear();
        int PrevVal = 1;
        int PrevNum = 0;
        int sumNum = 0;

        while (sumNum <= numFibo)
        {
            if (sumNum == numFibo)
            {
                return $"El numero {numFibo} (SI) es un número Fibonnacci";
            }
            sumNum = PrevNum + PrevVal;
            PrevNum = PrevVal;
            PrevVal = sumNum;
        }
        return $"El numero {numFibo} (NO) es un número Fibonnacci";
    }

    public static void FibonnacciNumList()
    {
        Console.WriteLine("Enter one Number :");
        int numFibo = int.Parse(Console.ReadLine());
        Console.Clear();
        int PrevVal = 1;
        int PrevNum = 0;
        int sumNum = 0;
        string listNumFib = $"{PrevNum.ToString()}  |  {PrevVal.ToString()}";
        for (int i = 1; i < numFibo; i++)
        {
            sumNum = PrevNum + PrevVal;
            PrevNum = PrevVal;
            PrevVal = sumNum;
            listNumFib += $"  | {sumNum}";
        }
        Console.WriteLine($"Fibonacci number list: \n" + listNumFib);
    }
}

