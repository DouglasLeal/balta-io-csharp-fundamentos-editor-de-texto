using System.IO;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Editor de Texto");
    Console.WriteLine("---------------");
    Console.WriteLine("1 - Abrir arquivo");
    Console.WriteLine("2 - Criar arquivo");
    Console.WriteLine();
    Console.WriteLine("0 - Sair");
    Console.WriteLine();

    Console.Write("Opção: ");
    short option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 0: Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Criar(); break;
        default: Menu(); break;
    }
}

static void Abrir()
{
    Console.Clear();
    Console.WriteLine("Digite o caminho do arquivo.");

    Console.Write("Caminho: ");
    var pathname = Console.ReadLine();

    using (var file = new StreamReader(pathname))
    {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
    }

    Console.WriteLine();
    Console.WriteLine("Aperte [ENTER] para continuar.");

    Console.ReadKey();

    Menu();
}

static void Criar()
{
    Console.Clear();
    Console.WriteLine("Digite o texto abaixo ([ESC] para sair)");
    Console.WriteLine("---------------------");
    Console.WriteLine();

    string text = "";

    do 
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    } 
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    Salvar(text);
}

static void Salvar(string text)
{
    Console.Clear();

    Console.WriteLine("Qual o caminho para salvar o arquivo?");
    Console.Write("Caminho: ");
    var pathname = Console.ReadLine();

    using (var file = new StreamWriter(pathname))
    {
        file.Write(text);
    }

    Console.WriteLine($"arquivo {pathname} salvo com sucesso");
    Console.WriteLine();
    Console.WriteLine("Aperte [ENTER] para continuar.");

    Console.ReadKey();

    Menu();
}
