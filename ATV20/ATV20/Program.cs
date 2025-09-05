using System;

class Jogo
{
    public string Nome;
    public string Plataforma;

    public Jogo(string nome, string plataforma)
    {
        Nome = nome;
        Plataforma = plataforma;
    }

    public void Jogar()
    {
        Console.WriteLine($"Jogando {Nome} no {Plataforma}!");
    }
}

class Program
{
    static void Main()
    {
        Jogo jogo1 = new Jogo("Gran Turismo 6", "PlayStation");
        Jogo jogo2 = new Jogo("Valorant", "PC");

        jogo1.Jogar();
        jogo2.Jogar();
    }
}

