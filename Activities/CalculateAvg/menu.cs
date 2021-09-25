using System;
public class menu
{
    public const int EXIT = 99;
    public void open(){
        average vAverage = new average();
        functions vFunction = new functions();
        int option;
        do{
            Console.WriteLine("\n\n.:CALCULO MEDIAS:.");
            Console.WriteLine("1: Media A,B");
            Console.WriteLine("2: Media A,B,C");
            Console.WriteLine("3: Media A,B,C,D");
            Console.WriteLine("4: Media A(40%),B(60%)");
            Console.WriteLine("5: Media A(30%),B(30%),C(40%)");
            Console.WriteLine("6: Media A(40%),B(60%)**");
            Console.WriteLine("**A = atv1 20% + prova1 80% e B = atv2 20% + prova2 60% + pluri 20%.");
            Console.WriteLine(menu.EXIT + ": Sair");
            Console.WriteLine("-----------------");
            Console.WriteLine("Option: ");
            option = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch (option)
            {
                case 1:
                    vFunction.message(vAverage.avg1(vFunction.getInput(2))); 
                    break;
                case 2:
                    vFunction.message(vAverage.avg2(vFunction.getInput(3)));
                    break;
                case 3:
                    vFunction.message(vAverage.avg3(vFunction.getInput(4)));
                    break;
                case 4: 
                    vFunction.message(vAverage.avg4(vFunction.getInput(2)));
                    break;
                case 5:
                    vFunction.message(vAverage.avg5(vFunction.getInput(3)));
                    break;
                case 6:
                    vFunction.message(vAverage.avg6(vFunction.getInput(5)));
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