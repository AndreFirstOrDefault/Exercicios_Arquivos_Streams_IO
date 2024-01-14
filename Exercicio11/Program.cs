/*
11- Criar um programa que liste todos os arquivos em um determinado diretório e suas subpastas usando a classe DirectoryInfo e a classe Path. 
*/
try
{
    Console.Write("Digite o caminho do diretório que deseja listar: ");
    string caminho = Console.ReadLine();

    DirectoryInfo directoryInfo = new DirectoryInfo(caminho);

    Console.WriteLine("\nListando todos os arquivos: \n");
    var arquivos = directoryInfo.GetFiles();

    foreach (var item in arquivos)
    {
        Console.WriteLine(item.Name);
    }

    Console.WriteLine("\nListando os subdiretórios: \n");
    var subdiretorios = directoryInfo.GetDirectories();

    foreach (var subdiretorio in subdiretorios)
    {
        Console.WriteLine(subdiretorio.Name);
    }
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}



Console.ReadKey();
