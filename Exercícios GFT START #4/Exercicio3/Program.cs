using System;
using System.Collections.Generic;

public class Agenda : Cliente
{
    public Agenda()
    {
        this.Nome = "";
        this.Descricao = "";
    }

    public Agenda(string nome, string descricao)
    {
        this.Nome = nome;
        this.Descricao = descricao;
    }

    private string nome;
    public string Nome
    {
        get { return this.nome; }

        set { this.nome = value.ToUpper(); }
    }
    private string descricao;
    public string Descricao
    {
        get { return this.descricao; }

        set { this.descricao = value.ToUpper(); }
    }
    public void ExibiDados()
    {
        //Console.WriteLine(" " + this.Nome + " Descricao: " + this.Descricao);
        Console.WriteLine("Contato: {0} - Descricao: {1}", this.Nome, this.Descricao);
    }
}

//programa principal
class Program
{
    static void Main(string[] args)
    {
        List<Agenda> Cliente = new List<Agenda>();
        int n = 0;
        Agenda agenda;

        Console.WriteLine("");
        Console.Write("");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("cadastro");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Leitura Agenda{0}", i);
            agenda = new Agenda();
            Console.Write("Nome: ");
            agenda.Nome = Console.ReadLine();
            Console.Write("Descricao: ");
            agenda.Descricao = Console.ReadLine();
            Cliente.Add(agenda);
        }

        Console.WriteLine("");
        for (int i = 0; i < n; i++)
        {
            Cliente[i].ExibiDados();
        }

        foreach (var item in Cliente)
        {
            Cliente.ExibiDados();
        }

        Console.ReadKey();
    }
}