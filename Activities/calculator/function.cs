using System;
using System.Linq; // for IEnumerable

public class function{
    public double[] getInput(int args){
        double[] input = new double[args];
        for(int value = 0; value < args; value++){
            Console.WriteLine("Arg " + value + ": ");
            input[value] = double.Parse(Console.ReadLine());
        }
        return input;
    }
    public double sum(params double[] values) {
        double sum = 0.0;
        foreach(double value in values)
            sum += value;
        return sum;
    }
    public double subtraction(params double[] values) {
        double result = values[0];
        foreach(double value in values.Skip(1))
            result -= value;
        return result;
    }
    public double multiply(params double[] values) {
        double result = values[0];
        foreach(double value in values.Skip(1))
            result *= value;
        return result;
    }
    public double division(params double[] values) {
        double result = values[0];
        foreach(double value in values.Skip(1))
            if(value != 0)
                result /= value;
            else
                Console.WriteLine("0 value was ignored... Proceeding with result");
        return result;
    }
    public int factorial(int n) {
        if(n == 0) return 1;
        return n * factorial(n-1);
    }  
}