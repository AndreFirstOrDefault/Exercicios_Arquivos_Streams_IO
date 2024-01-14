/*
14- Criar um programa que retorne o tamanho total de um diretório, incluindo todos os arquivos e subdiretórios, usando a classe Directory e a classe Path. 
*/

try
{
    Console.Write("Digite um caminho de diretório: ");
    string diretorio = Console.ReadLine();

    if (Path.Exists(diretorio))
    {
        long tamanhoTotal = GetDirectorySyze(diretorio);
        Console.WriteLine($"Tamanho total do diretório {diretorio}: {tamanhoTotal} bytes");
    }
    else
    {
        Console.WriteLine("O diretório não existe!");
    }
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

static long GetDirectorySyze(string diretorio)
{
    long tamanhoTotal = 0;
    foreach (string arquivo in Directory.GetFiles(diretorio, "*",
     SearchOption.AllDirectories))
    {
        FileInfo info = new FileInfo(arquivo);
        tamanhoTotal += info.Length;
    }
    return tamanhoTotal;
}


Console.ReadKey();