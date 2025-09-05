using System;
using System.Reflection.Metadata;

public class Animal
{
    public string Nome { get; set; } = "Papagaio";
    public int idade { get; set; } = 100;
}

class Program
{
    static void Main ()
    {
        Animal meuAnimal = new Animal ();
        meuAnimal.Nome = "Papagaio";
        meuAnimal.idade = 100;

        Console.WriteLine ("Nome: " + meuAnimal.Nome);
        Console.WriteLine ("Idade: " + meuAnimal.idade);
            
    }
}