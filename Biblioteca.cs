public class Biblioteca
{
    public List<Livro> Livros = new List<Livro>();
    public List<Pessoa> Pessoas = new List<Pessoa>();

    public Biblioteca()
    {
        Livros = new List<Livro>();
        Pessoas = new List<Pessoa>();
    }

    public void CadastrarLivro(Livro livro)
    {
        Livros.Add(livro);
    }

    public void CadastrarPessoa(Pessoa pessoa)
    {
        Pessoas.Add(pessoa);
    }

    public void ListarLivros()
    {
        foreach(Livro livro in Livros)
        {
            Console.WriteLine($"ID: {livro.Id} - Título: {livro.Titulo} - Status: {livro.Status}");
        }
    }

    public void EmprestarLivro(Livro livro, Pessoa pessoa)
    {
        livro.Emprestar(pessoa.Nome);
        pessoa.PegarLivro(livro);
    }
}