/*
12- Criar um programa que permita ao usuário excluir um arquivo ou diretório usando a classe Directory, a classe DirectoryInfo e a classe Path. 
*/


Console.Write("Para excluir um arquivo digite 1, para excluir um diretório digite 2: ");
int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.Write("\nDigite o caminho do arquivo: ");
        string caminhoArquivo = Console.ReadLine();
        ExcluirArquivo(caminhoArquivo);
        break;
    case 2:
        Console.Write("\nDigite o caminho do diretório: ");
        string caminhoDiretorio = Console.ReadLine();
        ExcluirDiretorio(caminhoDiretorio); 
        break;
}

static void ExcluirArquivo(string caminho)
{
    try
    {
        File.Delete(caminho);
        Console.WriteLine("\nArquivo excluido com sucesso.");
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

static void ExcluirDiretorio(string caminho)
{
    try
    {
        Directory.Delete(caminho,true);
        Console.WriteLine("\nDiretório excluido com sucesso.");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.ReadKey();
