using PushUpRazonamientoLogico;
using PushUpRazonamientoLogico.Entites;

internal class Program
{
    private static void Main(string[] args)
    {
        bool contWil = true;
        while (contWil)
        {
            byte respRta = Functions.MainMenu();

            switch (respRta)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine($"El número fibonnacci es: {Fibonnacci.CalNumFibo()}");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(Fibonnacci.VerNumFibo());
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Fibonnacci.FibonnacciNumList();
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    RussianMultiplication.GetRussianMultiplication();
                    Console.ReadKey();
                    break;
                case 5:
                    Console.Clear();
                    FriendlyNumbers.CheckFriendNumb2();
                    Console.ReadKey();
                    break;
                case 6:
                    Console.Clear();
                    ConfechVotes.GetDataUniv();
                    Console.ReadKey();
                    break;
                case 10:
                    contWil = false;
                    break;
                default:
                    Console.WriteLine($"The option Entered is invalid");
                    break;
            }
        }

    }
}