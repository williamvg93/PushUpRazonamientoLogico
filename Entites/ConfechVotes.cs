using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PushUpRazonamientoLogico.Entites;

public class ConfechVotes
{
    public static void GetDataUniv()
    {
        System.Console.WriteLine("Enter the number of universities: ");
        int numUni = int.Parse(Console.ReadLine());
        int uniAcep = 0;
        int uniRech = 0;
        int uniEmp = 0;
        string Votos = "";

        for (int i = 1; i <= numUni; i++)
        {

            int votosA = 0;
            int votosR = 0;
            int votosN = 0;
            int votosB = 0;
            System.Console.WriteLine("Enter the name of the university: ");
            string uniName = Console.ReadLine();
            bool contWhile = true;
            Votos += $"\nUniversity Name: {uniName}";
            while (contWhile)
            {
                string RtaVote = Functions.VotesMenu().ToUpper();
                switch (RtaVote)
                {
                    case "A":
                        Votos += "\nVoto: A";
                        /* System.Console.WriteLine("Voto: A"); */
                        votosA += 1;
                        break;
                    case "R":
                        Votos += "\nVoto: R";
                        /* System.Console.WriteLine("Voto: R"); */
                        votosR += 1;
                        break;
                    case "N":
                        Votos += "\nVoto: N";
                        /* System.Console.WriteLine("Voto: N"); */
                        votosN += 1;
                        break;
                    case "B":
                        Votos += "\nVoto: B";
                        /* System.Console.WriteLine("Voto: B"); */
                        votosB += 1;
                        break;
                    case "X":
                        Votos += "\nVoto: X";
                        contWhile = false;
                        break;
                    default:
                        System.Console.WriteLine("Enter a valid Option...");
                        break;
                }
            }
            if (votosA > votosR)
            {
                uniAcep += 1;
            }
            else if (votosA < votosR)
            {
                uniRech += 1;
            }
            else
            {
                uniEmp += 1;
            }

            Votos += $"{uniName}: {votosA} Aceptan, {votosR} Rechazan, {votosB} Blancos, {votosN} Nulos";
        }

        Console.WriteLine(Votos);
        System.Console.WriteLine($"\nUniversidades que aceptan: {uniAcep}\nUniversidades que rechazan: {uniRech}\nUniversidades con Empate: {uniEmp}");
    }
}
