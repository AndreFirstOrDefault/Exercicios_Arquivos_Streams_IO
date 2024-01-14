/*
10- Criar um programa que permita ao usuário mover um arquivo de um diretório para outro usando a classe File e a classe Path. 
*/

try
{
    Console.Write("Digite o caminho do diretório: ");
    string caminhoOrigem = Console.ReadLine();

    Console.Write("Digite o nome do arquivo que deseja mover: ");
    string nome = Console.ReadLine();

    Console.Write("Digite o caminho para onde o arquivo deva ser movido: ");
    string caminhoDestino = Console.ReadLine();

    Console.WriteLine("\nMovendo arquivo....");
    Thread.Sleep(2000);

    string origem = Path.Combine(caminhoOrigem, nome + ".txt");
    string destino = Path.Combine(caminhoDestino, nome + ".txt");

    File.Move(origem, destino);

    Console.WriteLine("\nArquivo movido com sucesso!");
}
catch (Exception e)
{
    Console.WriteLine($"{e.Message}");
}

Console.ReadKey();
