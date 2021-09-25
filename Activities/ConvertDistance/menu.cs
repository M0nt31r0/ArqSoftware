using System;
public class menu
{
    public const int EXIT = 99;
    public void open(){
        function vFunctions = new function();
        double value;
        int option;
        do{
            Console.WriteLine("\n\n.:DISTANCE CONVERTER:.\n");
            Console.WriteLine("Type value to be converted: ");
            value = double.Parse(Console.ReadLine());
            Console.WriteLine("Inform unit: ");
            Console.WriteLine("  1: milimeter  (mm)");
            Console.WriteLine("  2: centimeter (cm)");
            Console.WriteLine("  3: decimeter  (dm)");
            Console.WriteLine("  4: meter      (m)");
            Console.WriteLine("  5: inch       (in)");
            Console.WriteLine("  6: foot       (ft)");
            Console.WriteLine("  7: yard       (yd)");
            Console.WriteLine(menu.EXIT + ": QUIT");
            Console.WriteLine("Option: ");
            option = Int32.Parse(Console.ReadLine());
            if(option == 99) break;
            else if(!option.In(1,2,3,4,5,6,7))
                Console.WriteLine("Invalid Option! Type again...");
            else vFunctions.ShowConversionResult(value, option);
        }while(option != 99);
    }
}