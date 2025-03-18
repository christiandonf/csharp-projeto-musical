// Screen Sound
using System.Runtime.CompilerServices;
using System.Xml;

string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound";

//List<string> listaDasBandas = new List<string>{"U2","The Beatles","Linkin park","Pink Floyd","Calypso"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 9, 9, 9, 9, 8, 8, 6, 2, 14 });
bandasRegistradas.Add("The Beatles", new List<int>());

//string curso = "Screen Sound";
//string nome1 = "Daniel";
//string nome2 = "Guilherme";
//string sobrenome1 = " Portugal";
//string sobrenome2 = " Lima";
void ExibirLogo()
{
    System.Console.WriteLine(
        @"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    "
    );
    Console.WriteLine(mensagemDeBoasVindas);
    //Console.WriteLine(curso);
    //Console.WriteLine(nome1+sobrenome1);
    //Console.WriteLine(nome2+sobrenome2+"\n");
}
void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMediaNotasBanda();
            break;
        case -1:
            Console.WriteLine("Falow ae :)");
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    //listaDasBandas.Add(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo as bandas registradas");
    // for (int i =0; i < listaDasBandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {listaDasBandas[i]}");
    // }
    // foreach(string banda in listaDasBandas)
    // {
    //     Console.WriteLine($"Banda: {banda}");
    // }
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para volta ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteristicos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristicos + "\n");
}
void AvaliarUmaBanda()
{
    //Digite qual a banda deseja avaliar
    //Verificar se a banda está no dicionario >> atribuir uma nota
    //Senão, volta ao menu principal
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"\nQual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}
void ExibirMediaNotasBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Media de Notas da Banda");
    Console.Write("Digite o nome da banda que deseja ver a media de notas: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        int nota = (int)bandasRegistradas[nomeDaBanda].Average();
        Console.WriteLine($"\nA banda {nomeDaBanda} tem uma de notas igual a: {nota}");
        Console.Write("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}
ExibirOpcoesDoMenu();
