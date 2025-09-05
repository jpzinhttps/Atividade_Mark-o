using System;

class Veiculo
{
    public string Marca;
    public string Modelo;

    public Veiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public void Acelerar()
    {
        Console.WriteLine("Acelerando!");
    }
}

class Program
{
    static void Main()
    {
        Veiculo carro = new Veiculo("Toyota", "Corolla");
        Console.WriteLine("Marca: " + carro.Marca);
        Console.WriteLine("Modelo: " + carro.Modelo);
        carro.Acelerar();
    }
}

