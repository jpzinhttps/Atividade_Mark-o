using System;

class Data
{
    public int Dia;
    public int Mes;
    public int Ano;

   
    public Data(int dia, int mes, int ano)
    {
        Dia = dia;
        Mes = mes;
        Ano = ano;
    }

    
    public string Formatar()
    {
        return $"{Dia:D2}/{Mes:D2}/{Ano}";
    }
}

class Program
{
    static void Main()
    {
        Data data = new Data(25, 12, 1993);

        Console.WriteLine("Data formatada: " + data.Formatar());
    }
}

