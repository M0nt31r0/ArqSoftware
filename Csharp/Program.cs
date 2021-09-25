using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace menu
{
    class Program
    {
        public const int EXIT = 99;
        static int GetMenuOption(){
            string option;
            int value = 0;
            Console.WriteLine("TITLE");
            Console.WriteLine("1: ");
            Console.WriteLine("2: ");
            Console.WriteLine("3: ");
            Console.WriteLine("4: ");
            Console.WriteLine("99: Sair");
            do{
                Console.WriteLine("Option: ");
                option = Console.ReadLine();
                if(int.TryParse(option, out value)){
                    return int.Parse(option);
                }else{
                    Console.WriteLine("NaN. Please ENTER another option.");
                }
            }while(true);
        }
        static int Menu(int option){
            switch (option)
            {
                case 1: 

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case Program.EXIT:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
            return option;
        }
        static void Main(string[] args){
            while(Menu(GetMenuOption()) != Program.EXIT);
        }
    }
}