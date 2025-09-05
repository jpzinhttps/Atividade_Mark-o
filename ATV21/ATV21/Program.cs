using System;

class Pessoa
{
    private int _idade;

    public int Idade
    {
        get { return _idade; }
        set { _idade = value; }
    }
}

class Program
{
    static void Main()
    {
        Pessoa p = new Pessoa();
        p.Idade = 25;
        Console.WriteLine("Idade: " + p.Idade);
    }
}

