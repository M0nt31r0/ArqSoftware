#include <stdio.h>
#include <stdlib.h>
#define PI 3.1415926535

void getValues(int cod, float *a, float *b, float *c){
    switch(cod){
        case 1: 
            printf("Base: ");
            scanf("%f",a);
            printf("Altura: ");
            scanf("%f",b);
            break;
        case 2:
            printf("Lado A: ");
            scanf("%f",a);
            printf("Lado B: ");
            scanf("%f",b);
            break;
        case 3:
            printf("Raio: ");
            scanf("%f",a);
            break;
        case 4:
            printf("Base Menor: ");
            scanf("%f",a);
            printf("Base Maior: ");
            scanf("%f",b);
            printf("Altura: ");
            scanf("%f",c);
            break;
        case 5:
            printf("Diagonal A: ");
            scanf("%f",a);
            printf("Diagonal B: ");
            scanf("%f",b);
            break;
    }
}
float getTriangleArea(float a, float b){
    return (a*b)/2;
}
float getSquareArea(float a, float b){
    return a*b;
}
float getCircleArea(float a){
    return PI*a*a;
}
float getTrapeziumArea(float a, float b, float c){
    return ((a+b)*c)/2;
}
int InitialMessage(){
    int opt;
    printf("\n\t.:CALCULAR AREA FIGURA GEOMETRICA:.\n");
    printf("\n1  - Triangulo");
    printf("\n2  - Quadrado");
    printf("\n3  - Retangulo");
    printf("\n4  - Circulo");
    printf("\n5  - Trapezio");
    printf("\n6  - Losango");
    printf("\n9  - Sair");
    printf("\nOPT: ");
    scanf("%i",&opt);
    return opt;
}
void printMessage(float result){
    printf("AREA: %.2f", result);
}
int main()
{
    int opt;
    float a,b,c; 
    do{
        opt = InitialMessage();
        switch (opt)
        {
            case 1:
                getValues(1,&a,&b,&c);
                printMessage(getTriangleArea(a,b));
                break;
            case 2:
                getValues(2,&a,&b,&c);
                printMessage(getSquareArea(a,b));
                break;
            case 3:
                getValues(2,&a,&b,&c);
                printMessage(getSquareArea(a,b));
                break;
            case 4:
                getValues(3,&a,&b,&c);
                printMessage(getCircleArea(a));
                break;
            case 5:
                getValues(4,&a,&b,&c);
                printMessage(getTrapeziumArea(a,b,c));
                break;
            case 6:
                getValues(5,&a,&b,&c);
                printMessage(getSquareArea(a,b)/2);
                break;
            case 9:
                break;
            default:
                printf ("Invalid Option!\n");
        }
        }while(opt != 9);
    
    return 0;
}
