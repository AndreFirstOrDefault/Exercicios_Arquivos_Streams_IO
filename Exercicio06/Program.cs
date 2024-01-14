/*
 6- Criar um programa que liste todos os arquivos em um determinado diretório usando a classe Directory e a classe Path
 */

Console.Write("Digite um diretório que queira listar os arquivos: ");
string diretorio = Console.ReadLine();
Console.WriteLine();

if (diretorio != null)
{
    try 
    {
        string[] arquivos = Directory.GetFiles(diretorio);
        
        foreach (var arquivo in arquivos)
        {
            Console.WriteLine(Path.GetFileName(arquivo));
        }
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.ReadKey();