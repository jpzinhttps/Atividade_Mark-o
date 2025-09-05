using System;

class Usuario
{
    public string Nome;
    public string Email;

    public Usuario(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }

    public void AlterarEmail(string novoEmail)
    {
        Email = novoEmail;
    }
}

class Program
{
    static void Main()
    {
        Usuario u = new Usuario("Makita", "Makita1023@email.com");
        Console.WriteLine("Nome: " + u.Nome);
        Console.WriteLine("Email: " + u.Email);

        u.AlterarEmail("Makitaconstrucoes@email.com");
        Console.WriteLine("Email atualizado: " + u.Email);
    }
}

