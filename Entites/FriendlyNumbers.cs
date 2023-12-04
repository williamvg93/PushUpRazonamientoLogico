using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PushUpRazonamientoLogico.Entites;

public class FriendlyNumbers
{
    public static void CheckFriendNumb2()
    {

        for (int num1 = 1183; num1 <= 1400; num1++)
        {
            int sumDivNum1 = 0;
            string listNum1 = "";
            for (int e = 1; e < 1400; e++)
            {
                if (num1 != e)
                {
                    if (num1 % e == 0)
                    {
                        listNum1 += $"{e}  ";
                        sumDivNum1 += e;
                    }
                }
            }

            for (int num2 = 1183; num2 <= 1400; num2++)
            {
                int sumDivNum2 = 0;
                string listNum2 = "";
                for (int f = 1; f < 1400; f++)
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

                if (num1 == sumDivNum2 && num2 == sumDivNum1)
                {
                    Console.WriteLine($"numero: {num1} suma de sus divisores: {sumDivNum1}\nnumero: {num2} suma de sus divisores: {sumDivNum2}");
                    return;
                }
            }
        }
    }
}
