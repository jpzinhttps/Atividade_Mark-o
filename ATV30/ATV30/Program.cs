using System;
using System.Collections.Generic;

class Configuracao
{
    private Dictionary<string, string> _config = new Dictionary<string, string>();

    public void Set(string chave, string valor)
    {
        _config[chave] = valor;
    }

    public string Get(string chave)
    {
        if (_config.ContainsKey(chave))
            return _config[chave];
        return "Chave não encontrada";
    }
}

class Program
{
    static void Main()
    {
        Configuracao cfg = new Configuracao();
        cfg.Set("tema", "escuro");
        cfg.Set("idioma", "pt-BR");

        Console.WriteLine("Tema: " + cfg.Get("tema"));
        Console.WriteLine("Idioma: " + cfg.Get("idioma"));
        Console.WriteLine("Versão: " + cfg.Get("versao"));
    }
}

