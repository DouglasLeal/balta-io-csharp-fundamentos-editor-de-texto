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

}

static void Criar()
{

}
