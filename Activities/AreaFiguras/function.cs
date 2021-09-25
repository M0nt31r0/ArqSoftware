using System;

public class functions{
    public const double pi = 3.14159265359;
    public void message(double result){
        Console.WriteLine("----------------");
        System.Threading.Thread.Sleep(500);
        Console.WriteLine($"AREA: {result:0.00}");
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("----------------");
        System.Threading.Thread.Sleep(500);
    }
    public double sum(params double[] values) {
        double sum = 0.0;
        foreach(double value in values)
            sum += value;
        return sum;
    }
    public double getAreaSquare(double a, double b){
        return a*b;
    }
    public double getAreaCircle(double a){
        return pi*Math.Pow(a,2); 
    }
    public double getAreaTrapezium(double a, double b, double c){
        return sum(a,b)*c/2; 
    }
    public double getAreaHexagonum(double a){
        return 3*Math.Sqrt(3)*Math.Pow(a,2)/2; 
    }
}