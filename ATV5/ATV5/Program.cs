using System;

class Quadrado()
{
    public int Lado;

    public int Area() { return Lado * Lado; }
}
class Program
{
    static void Main()
    {
        Quadrado quadrado = new Quadrado();
        quadrado.Lado = 12;

        int Resultado = quadrado.Area();
        Console.WriteLine("Area: " + Resultado);
    
    }
}