using System;
using System.Collections.Generic;

class Biblioteca
{
    public List<string> Livros;

    public Biblioteca()
    {
        Livros = new List<string>();
    }

    public void AdicionarLivro(string titulo)
    {
        Livros.Add(titulo);
    }
}

class Program
{
    static void Main()
    {
        Biblioteca b = new Biblioteca();
        b.AdicionarLivro("Dom Casmurro");
        b.AdicionarLivro("O Pequeno Príncipe");

        Console.WriteLine("Livros na biblioteca:");
        foreach (string livro in b.Livros)
        {
            Console.WriteLine(livro);
        }
    }
}
