using System;
using System.Linq;

public class util{
    public double[] getInput(int args){
        double[] input = new double[args]; 
        char[] chars = {'A','B','C','D','E'};
        for(int value = 0; value < args; value++){
            Console.Write(chars[value] + ": ");
            input[value] = double.Parse(Console.ReadLine());
        }
        return input;
    }
    public void message(string result){
        System.Threading.Thread.Sleep(500);
        Console.WriteLine($"Result: {result}");
        System.Threading.Thread.Sleep(500);
    }
    public double sum(params double[] values) {
        double sum = 0.0;
        foreach(double value in values)
            sum += value;
        return sum;
    }
    public double divide(double value, int args) {
        return value/args;
    }
}