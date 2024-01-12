/*
 *  Escreva um programa que leia um caminho de arquivo do usuário e, em seguida, verifique se o arquivo 
    existe. Se o arquivo existir, mostre a data de criação do arquivo, caso contrário, exiba uma mensagem 
    informando que o arquivo não foi encontrado.

 */

Console.Write("Digite o caminho do arquivo: ");
string caminhoDoArquivo = Console.ReadLine();

try
{
    FileInfo fileInfo = new FileInfo(caminhoDoArquivo);
    if (fileInfo.Exists)
    {
        Console.Write($"\nData de criação do arquivo: {fileInfo.CreationTime.ToString("dd/MM/yyyy HH:mm" )}");
    }
    else
    {
        Console.WriteLine($"\nO arquivo {caminhoDoArquivo} não foi encontrado");
    }
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}



Console.ReadKey();