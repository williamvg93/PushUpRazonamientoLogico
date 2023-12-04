using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PushUpRazonamientoLogico.Entites;

public class FriendlyNumbers
{
    public static void CheckFriendNumb2()
    {
        System.Console.WriteLine("Inició");
        /* int num1 = 220; */
        /* int num2 = 284; */

        for (int num1 = 1000; num1 <= 1500; num1++)
        {
            int sumDivNum1 = 0;
            string listNum1 = "";
            for (int e = 1; e < 1500; e++)
            {
                if (num1 != e)
                {
                    /* System.Console.WriteLine("Es diferente"); */
                    if (num1 % e == 0)
                    {
                        /* Console.WriteLine($"Resultado: {num1 % e}"); */
                        listNum1 += $"{e}  ";
                        sumDivNum1 += e;
                        /* Console.WriteLine($"sumaDivNum1: {sumDivNum1}"); */

                    }
                }
            }

            for (int num2 = 1000; num2 <= 1500; num2++)
            {
                int sumDivNum2 = 0;
                string listNum2 = "";
                for (int f = 1; f < 1500; f++)
                {
                    if (num2 != f)
                    {
                        if (num2 % f == 0)
                        {
                            listNum2 += $"{f}  ";
                            sumDivNum2 += f;
                        }
                    }
                }
                /* Console.WriteLine($"num1: {num1}  sumanum1: {sumDivNum1}");
                Console.WriteLine($"num2: {num2}  sumanum2: {sumDivNum2}"); */

                if (num1 == sumDivNum2 && num2 == sumDivNum1)
                {
                    /* System.Console.WriteLine("Si hay"); */
                    Console.WriteLine($"numero: {num1} suma de sus divisores: {sumDivNum1}\n  numero: {num2} suma de sus divisores: {sumDivNum2}");
                    Console.WriteLine($"numero: {num1} Lista de sus divisores: {listNum1}\n  numero: {num2} Lista de sus divisores: {listNum2}");
                }
            }

        }
        System.Console.WriteLine("Finalizó la ejecución");

    }
}
