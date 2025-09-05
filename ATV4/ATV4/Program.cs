using System;
 
class Livro
{
    public string Titulo;
    public string Autor;

    public void ExibirInfo()
    {
        Console.WriteLine("Titulo: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
    }

    class Program
    {
        static void Main (string[] args)
        {
            Livro meuLivro = new Livro();
            meuLivro.Titulo = "Diário de um Banana";
            meuLivro.Autor = "Jeff Kinney";

            meuLivro.ExibirInfo();
        }
    }
}