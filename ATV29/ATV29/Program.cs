using System;

class Empregado
{
    private double _salario;

    public Empregado(double salario)
    {
        _salario = salario;
    }

    public double CalcularBonus()
    {
        return _salario * 0.1;
    }
}

class Program
{
    static void Main()
    {
        Empregado e = new Empregado(3000);
        Console.WriteLine("Bônus: " + e.CalcularBonus());
    }
}
