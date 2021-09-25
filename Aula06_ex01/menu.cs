using System;
public class menu
{
    public const int EXIT = 99;
    public void open(){
        medias vMedias = new medias();
        double a,b,c,d,avg = 0.0;
        int option;
        do{
            Console.WriteLine(".:CALCULO MEDIAS:.");
            Console.WriteLine("1: Media p1,p2");
            Console.WriteLine("2: Media p1,p2,p3");
            Console.WriteLine("3: Media p1,p2,p3,p4");
            Console.WriteLine(menu.EXIT + ": Sair");
            Console.WriteLine("Option: ");
            option = Int32.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: 
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    avg = vMedias.media2(a,b);
                    Console.WriteLine("Average is: " + avg.ToString());
                    break;
                case 2:
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    c = double.Parse(Console.ReadLine());
                    avg = vMedias.media2(a,b);
                    Console.WriteLine("Average is: " + avg.ToString());
                    break;
                case 3:
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    c = double.Parse(Console.ReadLine());
                    d = double.Parse(Console.ReadLine());
                    avg = vMedias.media2(a,b);
                    Console.WriteLine("Average is: " + avg.ToString());
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