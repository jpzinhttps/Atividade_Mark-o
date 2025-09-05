using System;

class Triangulo
{
    public int Lado1;
    public int Lado2;
    public int Lado3;

    public Triangulo(int lado1, int lado2, int lado3)
    {
        Lado1 = lado1;
        Lado2 = lado2;
        Lado3 = lado3;
    }

    public int Perimetro()
    {
        return Lado1 + Lado2 + Lado3;
    }
}

class Program
{
    static void Main()
    {
        Triangulo t = new Triangulo(25, 15, 13);
        Console.WriteLine("Perímetro: " + t.Perimetro());
    }
}
