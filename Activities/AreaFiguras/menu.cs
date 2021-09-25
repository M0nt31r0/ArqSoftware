using System;
public class menu
{
    public const int EXIT = 99;
    public void open(){
        functions vFunction = new functions();
        int option;
        double a,b,c;
        do{
            Console.WriteLine("\n\n.:CALCULO AREA:.");
            Console.WriteLine("1: Circulo");
            Console.WriteLine("2: Quadrado");
            Console.WriteLine("3: Retangulo");
            Console.WriteLine("4: Triangulo");
            Console.WriteLine("5: Trapezio");
            Console.WriteLine("6: Hexagono");
            Console.WriteLine("7: Pentagono Regular");
            Console.WriteLine("8: Paralelogramo");
            Console.WriteLine("9: Losango");
            Console.WriteLine(menu.EXIT + ": Sair");
            Console.WriteLine("-----------------");
            Console.WriteLine("Option: ");
            option = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Digite as dimensões: ");
            switch (option)
            {
                case 1:
                    Console.WriteLine("Raio: ");
                    a = double.Parse(Console.ReadLine());
                    vFunction.message(vFunction.getAreaCircle(a));
                    break;
                case 2: case 3: case 8:
                    Console.WriteLine("Lado A: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Lado B: ");
                    b = double.Parse(Console.ReadLine());
                    vFunction.message(vFunction.getAreaSquare(a,b));
                    break;
                case 4:
                    Console.WriteLine("Base: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura: ");
                    b = double.Parse(Console.ReadLine());
                    vFunction.message(vFunction.getAreaSquare(a,b)/2);
                    break;
                case 5:  
                    Console.WriteLine("Base Menor: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Base Maior: ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura: ");
                    c = double.Parse(Console.ReadLine());
                    vFunction.message(vFunction.getAreaTrapezium(a,b,c));
                    break;
                case 6:
                    Console.WriteLine("Lado: ");
                    a = double.Parse(Console.ReadLine());
                    vFunction.message(vFunction.getAreaHexagonum(a));
                    break;
                case 7:
                    Console.WriteLine("Lado: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura: ");
                    b = double.Parse(Console.ReadLine());
                    vFunction.message(vFunction.getAreaSquare(a,b)/2*5);
                    break;  
                case 9:
                    Console.WriteLine("Diagonal Menor: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Diagonal Maior: ");
                    b = double.Parse(Console.ReadLine());
                    vFunction.message(vFunction.getAreaSquare(a,b)/2);
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