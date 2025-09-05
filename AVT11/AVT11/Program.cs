using System;

class Retangulo
{
    public int Largura;
    public int Altura;

    
    public Retangulo(int largura, int altura)
    {
        Largura = largura;
        Altura = altura;
    }

  
    public int Area()
    {
        return Largura * Altura;
    }
}

class Program
{
    static void Main()
    {
        
        Retangulo r = new Retangulo(8, 3);

        Console.WriteLine("Largura: " + r.Largura);
        Console.WriteLine("Altura: " + r.Altura);
        Console.WriteLine("Área: " + r.Area());
    }
}

