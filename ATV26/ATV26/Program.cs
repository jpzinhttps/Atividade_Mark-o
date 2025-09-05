using System;

class Usuario
{
    private string _senha;

    public Usuario(string senha)
    {
        _senha = senha;
    }

    public bool Autenticar(string senhaInformada)
    {
        return _senha == senhaInformada;
    }
}

class Program
{
    static void Main()
    {
        Usuario u = new Usuario("12345");
        Console.WriteLine("Autenticação correta: " + u.Autenticar("12345"));
        Console.WriteLine("Autenticação incorreta: " + u.Autenticar("54321"));
    }
}
