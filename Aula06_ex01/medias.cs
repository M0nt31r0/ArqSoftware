using System;
public class medias{
    public double somar(double va, double vb) {
        double soma = 0.0;
        soma = va + vb;
        return soma;
    }
    public double media2(double nota1, double nota2) {
        return somar(nota1, nota2) / 2;
    }
    public double media3(double nota1, double nota2, double nota3) {
        return somar(somar(nota1, nota2), nota3) / 3;
    }
    public double media4(double nota1, double nota2, double nota3, double nota4) {
        return (somar(nota1, nota2) + somar(nota4, nota3)) / 4;
    }
}