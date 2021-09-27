using System;
public class menu
{
    public const int EXIT = 99;
    public void open(){
        util vUtil = new util();
        int option;
        do{
            Console.WriteLine("\n.::.");
            Console.WriteLine("1: ");
            Console.WriteLine("2: ");
            Console.WriteLine("3: ");
            Console.WriteLine("4: ");
            Console.WriteLine("5: ");
            Console.WriteLine("6: ");
            Console.WriteLine(menu.EXIT + ": Sair");
            Console.WriteLine("-----------------");
            Console.Write("Option: ");
            option = Int32.Parse(Console.ReadLine());
            Console.WriteLine("...");

            switch (option)
            {
                case 1:
                    vUtil.message(1123456.ToString());
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4: 
                    
                    break;
                case 5:
                    
                    break;
                case 6:
                    
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