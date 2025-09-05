using System;

class Circulo
{
    public double Raio;
    public double Area()
    {
        return Math.PI * Raio * Raio;
    }

    public double Perimetro ()
    {
        return 2 * Math.PI * Raio;
    }

    class Program()
    {
        static void Main()
        {
            Circulo circulo = new Circulo();
            circulo.Raio = 5;

            Console.WriteLine("Raio: " + circulo.Raio);
            Console.WriteLine("Area: " + circulo.Area());
            Console.WriteLine("Perimetro" + circulo.Perimetro());
        }
    }
}
