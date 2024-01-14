/*
13- Criar um programa que renomeie um arquivo usando a classe File e a classe Path
*/

try
{
    Console.WriteLine("### Renomeando arquivo ###\n");
    Console.Write("Digite o caminho do diretório: ");
    string diretorio = Console.ReadLine();

    Console.Write("Digite o nome do arquivo que deseja renomear: ");
    string nomeArquivo = Console.ReadLine() + ".txt";

    Console.Write("Digite o novo nome do arquivo: ");
    string nomeNovo = Console.ReadLine() + ".txt";

    if (Path.Exists(diretorio))
    {
        File.Move((Path.Combine(diretorio,nomeArquivo)),(Path.Combine(diretorio,nomeNovo)));
        Console.WriteLine("Arquivo renomeado com sucesso!");
    }
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}


Console.ReadKey();