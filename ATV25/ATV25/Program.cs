using System;

class Carro
{
    private int _velocidade = 0;

    public void Acelerar(int incremento)
    {
        _velocidade += incremento;
        if (_velocidade > 200) _velocidade = 200;
    }

    public int Velocidade()
    {
        return _velocidade;
    }
}

class Program
{
    static void Main()
    {
        Carro c = new Carro();
        c.Acelerar(50);
        Console.WriteLine("Velocidade: " + c.Velocidade());
        c.Acelerar(200);
        Console.WriteLine("Velocidade após aceleração máxima: " + c.Velocidade());
    }
}

