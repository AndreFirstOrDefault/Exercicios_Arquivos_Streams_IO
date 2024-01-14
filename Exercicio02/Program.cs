/*
    Escreva um programa que copie um arquivo de um diretório para outro. O nome e o caminho do arquivo de 
    origem e destino devem ser fornecidos pelo usuário. 
*/

Console.Write("Digite o nome do arquivo que deseja mover: ");
string arquivo = Console.ReadLine();

Console.Write("\nDigite o caminho de origem do arquivo: ");
string caminhoDeOrigem = Console.ReadLine();

Console.Write("\nDigite o caminho de destino do arquivo: ");
string caminhoDeDestino = Console.ReadLine();

caminhoDeOrigem = caminhoDeOrigem + "/" + arquivo;
caminhoDeDestino = caminhoDeDestino + "/" + arquivo;

try
{
    File.Copy(caminhoDeOrigem, caminhoDeDestino);
    Console.WriteLine($"Arquivo movido de {caminhoDeOrigem} para {caminhoDeDestino}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

Console.ReadKey();