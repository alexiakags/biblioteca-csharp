using System.Data.Common;
using System.Net;

public class Livro
{
    public int Id {get;set;}
    public string Titulo {get;set;}
    public string Status {get;set;} //Disponivel ou emprestado
    public string Locatario {get;set;}

const string Disponivel = "Disponivel";
const string Emprestado = "Emprestado";

    public Livro(int id, string titulo)
    {
        Id=id;
        Titulo=titulo;
        Status = Disponivel;
        Locatario = string.Empty;
    }

    public void Emprestar(string nomeLocatario)
    {
        if (Status == Emprestado)
        {
            Console.WriteLine("O livro não está disponível no momento.");
        }
        else
        {
            Status = Emprestado;
            Locatario = nomeLocatario;
            Console.WriteLine($"{Titulo} emprestado para {nomeLocatario}");
        }
    }

    public void Devolver()
    {
        Status = Disponivel;
        Locatario = string.Empty;
        Console.Write("Livro devolvido com sucesso!\n");
    }
}