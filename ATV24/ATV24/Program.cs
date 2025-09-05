using System;

class Produto
{
    private double _preco;

    public Produto(double preco)
    {
        _preco = preco;
    }

    public void AplicarDesconto(double percentual)
    {
        double desconto = _preco * percentual / 100;
        _preco -= desconto;
        if (_preco < 0) _preco = 0;
    }

    public double Preco()
    {
        return _preco;
    }
}

class Program
{
    static void Main()
    {
        Produto p = new Produto(100);
        p.AplicarDesconto(20);
        Console.WriteLine("Preço com desconto: " + p.Preco());
        p.AplicarDesconto(90);
        Console.WriteLine("Preço após grande desconto: " + p.Preco());
    }
}

