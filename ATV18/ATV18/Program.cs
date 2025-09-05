using System;

class Calculadora
{
    public Calculadora() { }

    public int Somar(int a, int b)
    {
        return a + b;
    }

    public int Subtrair(int a, int b)
    {
        return a - b;
    }

    public int Multiplicar(int a, int b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    {
        return a / b;
    }
}

class Program
{
    static void Main()
    {
        Calculadora calc = new Calculadora();

        Console.WriteLine("Soma: " + calc.Somar(8, 5));
        Console.WriteLine("Subtração: " + calc.Subtrair(30, 5));
        Console.WriteLine("Multiplicação: " + calc.Multiplicar(2, 5));
        Console.WriteLine("Divisão: " + calc.Dividir(4, 5));
    }
}

