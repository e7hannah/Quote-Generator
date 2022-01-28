using System;

namespace Quote_Generator
{
    public class Program
    {
        public static void Main()
        {
            Manager m = new Manager();
            m.showMenu();
        }
    }
}

class Manager
{
public void showMenu()
    {
        int num = 0;
        string userChoice = string.Empty;
        do
        {
            Console.WriteLine("Welcome to the Quote Generator!");
            Console.WriteLine("Please enter the number below that corresponds to the quote type that you would like to recieve");
            Console.WriteLine("OR enter #4 to exit");
            Console.WriteLine("1: Motivational");
            Console.WriteLine("2: Mood Enhancer");
            Console.WriteLine("3: Funny");
            Console.WriteLine("4: Exit");
            Console.Write("Enter your number choice:");
            if (num == 4)
                break;
            else
            userChoice = Console.ReadLine();

        }
        while (Int32.TryParse(userChoice, out num)); //checks to see if the input is a number
        if (userChoice == "4")
        {
            Environment.Exit(0);
        }


        if (userChoice == "1")
        {
            Console.WriteLine("Here is your motivational quote! + ");
        }
}

