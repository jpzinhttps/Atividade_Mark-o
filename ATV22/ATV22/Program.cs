using System;

class Conta
{
    private double saldo = 0;

    public void Depositar(double valor)
    {
        saldo += valor;
    }

    public bool Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
            return true;
        }
        return false;
    }

    public double Saldo()
    {
        return saldo;
    }
}

class Program
{
    static void Main()
    {
        Conta c = new Conta();
        c.Depositar(100);
        Console.WriteLine("Saldo: " + c.Saldo());
        bool saque = c.Sacar(50);
        Console.WriteLine("Saque aprovado: " + saque + ", Saldo: " + c.Saldo());
    }
}

