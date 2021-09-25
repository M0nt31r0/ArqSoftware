using System;
using System.Linq;

public static class Ext {    
    public static bool In<T>(this T t,params T[] values){
        return values.Contains(t);
    }
}
public class function{
    public void ShowConversionResult(double value, int option){
        double mm, cm, dm, m, pol, ft, yd;
        // convert all to meters
        m = value;
        if(option == 1) 
            m = divide(value, 1000);    // mm to m  
        else if(option == 2) 
            m = divide(value, 100);     // cm to m   
        else if(option == 3) 
            m = divide(value, 10);      // dm to m
        else if(option == 5) 
            m = divide(value, 39.370);  // in to m
        else if(option == 6) 
            m = divide(value, 3.2808);  // ft to m
        else if(option == 7)
            m = divide(value, 1.0936);  // yd to m
        // convert to other units
        mm = multiply(m, 1000);
        cm = multiply(m, 100);
        dm = multiply(m, 10);
        pol = multiply(m, 39.370);
        ft = multiply(m, 3.2808);
        yd = multiply(m, 1.0936);
        
        Console.WriteLine(@$"
mm: {mm:0.000}
cm: {cm:0.000}
dm: {dm:0.000}
m:  {m:0.000}
in: {pol:0.000}
ft: {ft:0.000}
yd: {yd:0.000}");
    }
    public double multiply(params double[] values) {
        double result = values[0];
        foreach(double value in values.Skip(1))
            result *= value;
        return result;
    }
    public double divide(params double[] values) {
        double result = values[0];
        foreach(double value in values.Skip(1))
            if(value != 0)
                result /= value;
            else
                Console.WriteLine("0 value was ignored... Proceeding with result");
        return result;
    }
    
}
