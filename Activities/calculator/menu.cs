using System;
public class menu
{
    public const int EXIT = 99;
    public const int NumArgs = 2;
    public void open(){
        function vFunctions = new function();
        int input;
        int option;
        do{
            Console.WriteLine(".:CALCULATOR:.\n");
            Console.WriteLine("1: Sum");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Square Root");
            Console.WriteLine("6: Potency");
            Console.WriteLine("7: Factorial");
            Console.WriteLine(menu.EXIT + ": QUIT");
            Console.WriteLine("Option: ");
            option = Int32.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Type args: ");
                    Console.WriteLine("Result: " + vFunctions.sum(vFunctions.getInput(NumArgs)));
                    break;
                case 2:
                    Console.WriteLine("Type args: ");
                    Console.WriteLine("Result: " + vFunctions.subtraction(vFunctions.getInput(NumArgs)));
                    break;
                case 3:
                    Console.WriteLine("Type args: ");
                    Console.WriteLine("Result: " + vFunctions.multiply(vFunctions.getInput(NumArgs)));
                    break;
                case 4: 
                    Console.WriteLine("Type args: ");
                    Console.WriteLine("Result: " + vFunctions.division(vFunctions.getInput(NumArgs)));
                    break;
                case 5:
                    Console.WriteLine("Type args: ");
                    Console.WriteLine("Result: " + Math.Sqrt(vFunctions.getInput(1)[0]));
                    break;
                case 6:
                    Console.WriteLine("Type args: ");
                    Console.WriteLine("Result: " + Math.Pow(vFunctions.getInput(1)[0], vFunctions.getInput(1)[0]));
                    break;
                case 7:
                    Console.WriteLine("Type args: ");
                    Console.WriteLine("Arg 0: ");
                    input = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + vFunctions.factorial(input));
                    break;
                case menu.EXIT:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
        }while(option != menu.EXIT);
    }
}