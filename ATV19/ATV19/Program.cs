using System;
using System.Collections.Generic;

class Agenda
{
    public List<string> Contatos;

    public Agenda(List<string> contatos)
    {
        Contatos = contatos;
    }

    public string BuscarContato(string nome)
    {
        foreach (string contato in Contatos)
        {
            if (contato.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                return contato;
            }
        }
        return "Contato não encontrado";
    }
}

class Program
{
    static void Main()
    {
        List<string> contatos = new List<string> { "Gabriel", "Anitta", "Italo Santos" };
        Agenda agenda = new Agenda(contatos);

        Console.WriteLine("Buscar 'Anitta': " + agenda.BuscarContato("Anitta"));
        Console.WriteLine("Buscar 'Italo Santos': " + agenda.BuscarContato("Italo Santos"));
    }
}
