using System;

class Carro {
    public string Cor = "Vermelho";
}

class Program
{
    

    static void Main ()
    {
        Carro myCarro = new Carro();
        Console.WriteLine(myCarro.Cor);
    }
}