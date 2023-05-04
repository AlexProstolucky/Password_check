using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string patern = @"^(?=.*[a-z])(?=.*[0-9])(?=.*[A-Z])(?=.*[*#+@])(?!.*\s).{4,6}$";
        Regex rg = new Regex(patern);
        Console.WriteLine("Write your passwords:\n");
        string str = Console.ReadLine();
        if (rg.IsMatch(str)) 
        {
            Console.WriteLine("Correct!");
        }
        else Console.WriteLine("Uncorrect!");
        Console.Write("\b");
    }
}