using System;
using System.Collections.Generic;

class Banco
{
    private List<int> contas = new List<int>();

    public void AdicionarConta(int id)
    {
        contas.Add(id);
    }

    public bool RemoverConta(int id)
    {
        return contas.Remove(id);
    }

    public void MostrarContas()
    {
        Console.WriteLine("Contas: " + string.Join(", ", contas));
    }
}

class Program
{
    static void Main()
    {
        Banco b = new Banco();
        b.AdicionarConta(101);
        b.AdicionarConta(102);
        b.MostrarContas();
        b.RemoverConta(101);
        b.MostrarContas();
    }
}
