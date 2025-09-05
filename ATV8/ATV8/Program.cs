using System;

class ContaBancaria
{
    public double Saldo = 0;

    public void Depositar(double valor)
    {
        Saldo += valor;
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria();

        Console.WriteLine("Saldo inicial: " + conta.Saldo);

        conta.Depositar(1200.5);
        Console.WriteLine("Saldo após depósito: " + conta.Saldo);
    }
}
