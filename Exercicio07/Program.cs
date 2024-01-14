/*
7- Criar um programa que liste todos os subdiretórios em um determinado diretório usando a classe DirectoryInfo. 
*/
Console.Write("Digite o caminho do diretório que deseja listar: ");
string diretorio = Console.ReadLine();
Console.WriteLine();

if (diretorio != null)
{
    try
    {
        DirectoryInfo dirInfo = new DirectoryInfo(diretorio);
        foreach (var subdiretorio in dirInfo.GetDirectories())
        {
            Console.WriteLine(subdiretorio.Name);
        }
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.ReadKey();