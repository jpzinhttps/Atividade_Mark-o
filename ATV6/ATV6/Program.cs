using System;

class Aluno
{
    public string Nome;
    public int Nota;
}

class Program
{
    static void Main()
    {
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "Jefferson";
        aluno1.Nota = 9;

        Aluno aluno2 = new Aluno();
        aluno2.Nome = "Gabriel Lyan";
        aluno2.Nota = 6;

        if (aluno1.Nota > aluno2.Nota)
        {
            Console.WriteLine(aluno1.Nome + " tem a maior nota: " + aluno1.Nota);
        }
        else if (aluno2.Nota > aluno1.Nota)
        {
            Console.WriteLine(aluno2.Nome + " tem a maior nota: " + aluno2.Nota);
        }
        else
        {
            Console.WriteLine("Ambos têm a mesma nota: " + aluno1.Nota);
        }
    }
}

