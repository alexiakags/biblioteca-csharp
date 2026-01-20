Biblioteca biblioteca = new Biblioteca();
Livro livro1 = new Livro(1,"Orgulho e preconceito");
Livro livro2 = new Livro(2,"O príncipe");
Livro livro3 = new Livro(3,"Almas mortas");
biblioteca.CadastrarLivro(livro1);
biblioteca.CadastrarLivro(livro2);
biblioteca.CadastrarLivro(livro3);

while(true){

    Console.WriteLine("Bem vindo a Biblioteca Ponei!");

    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Listar todos os livros");
    Console.WriteLine("2 - Emprestar livro");
    Console.WriteLine("3 - Sair");

    int opcaoEscolhida = int.Parse(Console.ReadLine());

    if(opcaoEscolhida == 1)
    {
        biblioteca.ListarLivros();
    }
    if(opcaoEscolhida == 2)
    {
        Console.WriteLine("Digite o nome de quem irá pegar o livro:");
        string nome = Console.ReadLine();
        Pessoa novoUsuario = new Pessoa(1,nome);

        biblioteca.CadastrarPessoa(novoUsuario);

        Console.WriteLine("Por favor, escolha o livro desejado, utilizando o Id: ");
        biblioteca.ListarLivros();
        int idLivroEscolhido = int.Parse(Console.ReadLine());
        Livro? livroEscolhido = biblioteca.Livros.Find(item => item.Id == idLivroEscolhido);

        if (livroEscolhido == null)
        {
            Console.WriteLine("Livro não encontrado.");
            return;
        }

        biblioteca.EmprestarLivro(livroEscolhido, novoUsuario);
    }
    if (opcaoEscolhida == 3)
    {
        break;
    }
    
}