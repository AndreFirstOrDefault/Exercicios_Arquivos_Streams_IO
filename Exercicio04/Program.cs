/*
4- Escreva um programa que leia o conteúdo de um arquivo de texto e o criptografe usando o algoritmo de criptografia     AES. Em seguida, salve o arquivo criptografado em um novo arquivo. O nome do arquivo de origem e destino deve ser     fornecido pelo usuário.
*/

using System.Security.Cryptography;

string caminhoOrigem = @"d:/dados/";
string caminhoDestino = @"d:/dados2/";

Console.Write("Digite o nome do arquivo de origem: ");
string arquivoOrigem = Console.ReadLine();

Console.Write("Digite o nome do arquivo de destino: ");
string arquivoDestino = Console.ReadLine();
string caminhoOrigemCompleto = caminhoOrigem + arquivoOrigem;
string caminhoDestinoCompleto = caminhoDestino + arquivoDestino;

Aes aes = Aes.Create();

ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key,aes.IV);
MemoryStream ms = new MemoryStream();
FileStream fs = new FileStream(caminhoOrigemCompleto, FileMode.OpenOrCreate);
var arq = new BinaryWriter(fs);

using(CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
{
    cs.Write(new BinaryWriter(fs));
    using(StreamWriter sw = new StreamWriter(cs))
        sw.Write(arquivoOrigem);
     var encrypted = ms.ToArray();

    using (File.CreateText(caminhoDestinoCompleto)) { }
        File.WriteAllBytes(caminhoDestinoCompleto, encrypted);
}

Console.ReadKey();