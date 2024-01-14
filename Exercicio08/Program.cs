/*
    8- Criar um programa que permita ao usuário criar um novo diretório e, em seguida, criar um arquivo dentro desse diretório usando a classe Directory e a classe Path. 
*/

try
{
    Console.Write("Digite o caminho para o novo diretório: ");
    string caminho = Console.ReadLine();

    Console.Write("Digite o nome do novo diretório: ");
    string nome = Console.ReadLine();

    // Obtendo o caminho completo para o novo diretório
    string caminhoCompleto = Path.Combine(caminho, nome);

    // Criando o diretório
    Directory.CreateDirectory(caminhoCompleto);
    Console.WriteLine($"Diretório criado com sucesso em: {caminhoCompleto}\n");

    Console.Write("Digite o nome do arquivo que deseja criar: ");
    string nomeArquivo = Console.ReadLine();
    
    // Criando arquivo no novo diretório
    File.Create(Path.Combine(caminhoCompleto, nomeArquivo + ".txt"));
    Console.WriteLine($"Arquivo criado com sucesso em: {Path.Combine(caminhoCompleto, nomeArquivo)}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

Console.ReadKey();