using System;

class Funcionario
{
    public string Nome;
    public double Salario;

    
    public Funcionario(string nome, double salario)
    {
        Nome = nome;
        Salario = salario;
    }

    
    public void AumentarSalario(double percentual)
    {
        Salario += Salario * percentual / 100;
    }
}

class Program
{
    static void Main()
    {
        Funcionario f = new Funcionario("Ana", 3200.00);

        Console.WriteLine("Funcionário: " + f.Nome);
        Console.WriteLine("Salário antes: " + f.Salario);

        f.AumentarSalario(10); 

        Console.WriteLine("Salário após aumento: " + f.Salario);
    }
}

