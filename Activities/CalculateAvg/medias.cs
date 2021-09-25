using System;
using System.Linq; // for IEnumerable

public class average{
    functions vFunction = new functions();
    public double avg1(params double[] grades) {
        return vFunction.divide(vFunction.sum(grades[0],grades[1]),2);
    }
    public double avg2(params double[] grades) {
        return vFunction.divide(vFunction.sum(grades[0],grades[1],grades[2]), 3);
    }
    public double avg3(params double[] grades) {
        return vFunction.divide(vFunction.sum(grades[0],grades[1],grades[2],grades[3]), 4);
    }
    public double avg4(params double[] grades) {
        return vFunction.sum(grades[0]*0.3,grades[1]*0.6);
    }
    public double avg5(params double[] grades) {
        return vFunction.sum(grades[0]*0.3,grades[1]*0.3,grades[2]*0.4);
    }
    public double avg6(params double[] grades) {
        return vFunction.sum((vFunction.sum(grades[0]*0.20,grades[1]*0.80)*0.40),(vFunction.sum(grades[2]*0.2,grades[3]*0.6,grades[4]*0.2)*0.60));
    }
    
}