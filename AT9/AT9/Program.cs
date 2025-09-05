using System;


class Produto
{
    public string Nome;
    public double Preco;

    public void AplicarDesconto()
    {
        Preco = Preco * 0.9;
    }
}

class Program
{
    static void Main()
    {
        Produto p = new Produto();
        p.Nome = "Controle Gamesir";
        p.Preco = 300.00;

        Console.WriteLine("Produto: " + p.Nome);
        Console.WriteLine("Preço original: " + p.Preco);

        p.AplicarDesconto(); 
        Console.WriteLine("Preço com desconto: " + p.Preco);
    }
}
