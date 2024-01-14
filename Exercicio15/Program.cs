/*
15- Criar um programa que retorne o nome do arquivo mais recente em um diretório usando a classe DirectoryInfo e a classe Path 
 */

try
{
    Console.WriteLine("Digite o caminho do diretório que deseja pesquisar: ");
    string diretorio = Console.ReadLine();

    if (Path.Exists(diretorio))
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(diretorio);
        var arquivos = directoryInfo.GetFiles();

        DateTime ultimaModificacao = DateTime.MinValue;
        string nomeArquivoRecente = string.Empty;

        foreach (var item in arquivos)
        {
            if(item.LastWriteTime > ultimaModificacao)
            {
                ultimaModificacao = item.LastWriteTime;
                nomeArquivoRecente = item.Name;
            }
        }

        if (!string.IsNullOrEmpty(nomeArquivoRecente))
        {
            Console.WriteLine($"O arquivo mais recente em {diretorio} é {Path.Combine(diretorio,nomeArquivoRecente)}");
        }
        else
        {
            Console.WriteLine($"Não foi encontrado nenhum arquivo em: {diretorio}");
        }
        
    }
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}


Console.ReadKey();