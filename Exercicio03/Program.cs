/*
3- Escreva um programa que crie um arquivo e escreva algumas informações nele. Em seguida, abra o arquivo 
novamente e adicione mais algumas informações a ele. Em seguida, leia o conteúdo do arquivo e exiba-o na 
tela. 
*/

string texto = "A tecnologia é um conjunto de conhecimentos, técnicas e ferramentas que permitem criar, modificar e melhorar a realidade. A tecnologia está presente em todos os aspectos da vida humana, desde a comunicação, a saúde, a educação, o lazer, até a produção, o transporte, a segurança e o meio ambiente.";

string caminho = @"d:/dados/exercicio03.txt";

try
{
    // criando o arquivo e escrevendo
    File.WriteAllText(caminho, texto);

    Console.WriteLine("Arquivo criado e texto gravado! Pressione enter para adicionar mais texto e exibir na tela\n");
    Console.ReadKey();

    // adicionado uma quebra de linha e mais contéudo no final do arquivo
    string texto2 = Environment.NewLine + "A tecnologia é fruto da criatividade, da inovação e da pesquisa científica. A tecnologia evolui constantemente, buscando atender às necessidades, aos desafios e aos sonhos da humanidade. A tecnologia pode trazer benefícios e oportunidades, mas também pode gerar riscos e problemas. Por isso, é importante usar a tecnologia de forma consciente, ética e responsável.";

    

    File.AppendAllText(caminho, texto2);

    // lendo o conteúdo do arquivo
    string conteudo = File.ReadAllText(caminho);
    Console.WriteLine(conteudo);

}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}


Console.ReadKey();
