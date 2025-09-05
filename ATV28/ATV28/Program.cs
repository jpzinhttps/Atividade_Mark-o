using System;

class Forma
{
    private double _area;

    public Forma(double area)
    {
        _area = area;
    }

    public double Area
    {
        get { return _area; }
    }
}

class Program
{
    static void Main()
    {
        Forma f = new Forma(50);
        Console.WriteLine("Área: " + f.Area);
    }
}

