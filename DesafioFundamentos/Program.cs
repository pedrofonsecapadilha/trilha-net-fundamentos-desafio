using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

// Exibir uma mensagem estilizada
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@"                                                                                                  ");
Console.WriteLine(@"  _   ______       _                _                                               _           _ ");
Console.WriteLine(@" | | |  ____|     | |              (_)                                             | |         | |");
Console.WriteLine(@" | | | |__    ___ | |_  __ _   ___  _   ___   _ __    __ _  _ __ ___    ___  _ __  | |_  ___   | |");
Console.WriteLine(@" | | |  __|  / __|| __|/ _` | / __|| | / _ \ | '_ \  / _` || '_ ` _ \  / _ \| '_ \ | __|/ _ \  | |");
Console.WriteLine(@" |_| | |____ \__ \| |_| (_| || (__ | || (_) || | | || (_| || | | | | ||  __/| | | || |_| (_) | |_|");
Console.WriteLine(@" (_) |______||___/ \__|\__,_| \___||_| \___/ |_| |_| \__,_||_| |_| |_| \___||_| |_| \__|\___/  (_)");
Console.WriteLine(@"                                                                                                  ");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("\nBEM VINDX AO SISTEMA DE COBRANÇA DO ESTACIONAMENTO\n");
Console.WriteLine("No primeiro acesso precisamos definir os valores do estacionamento.");

do
{
    Console.WriteLine("Digite o valor do PREÇO INICIAL [R$]: ");
    if (decimal.TryParse(Console.ReadLine(), out precoInicial))
    {
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Erro, o valor digitado é invalido!\nTente novamente, ex.: 6.50");
        Console.ForegroundColor = ConsoleColor.White;
    }
} while(true);

do
{
    Console.WriteLine("Digite o valor do PREÇO DA HORA [R$/h]:");
    if (decimal.TryParse(Console.ReadLine(), out precoPorHora))
    {
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Erro, o valor digitado é invalido!\nTente novamente, ex.: 2.75");
        Console.ForegroundColor = ConsoleColor.White;
    }
} while(true);

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"                                                                                                  ");
    Console.WriteLine(@"  _   ______       _                _                                               _           _ ");
    Console.WriteLine(@" | | |  ____|     | |              (_)                                             | |         | |");
    Console.WriteLine(@" | | | |__    ___ | |_  __ _   ___  _   ___   _ __    __ _  _ __ ___    ___  _ __  | |_  ___   | |");
    Console.WriteLine(@" | | |  __|  / __|| __|/ _` | / __|| | / _ \ | '_ \  / _` || '_ ` _ \  / _ \| '_ \ | __|/ _ \  | |");
    Console.WriteLine(@" |_| | |____ \__ \| |_| (_| || (__ | || (_) || | | || (_| || | | | | ||  __/| | | || |_| (_) | |_|");
    Console.WriteLine(@" (_) |______||___/ \__|\__,_| \___||_| \___/ |_| |_| \__,_||_| |_| |_| \___||_| |_| \__|\___/  (_)");
    Console.WriteLine(@"                                                                                                  ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Preço Inicial: R$ {precoInicial:F2}\nPreço por Hora: R$ {precoPorHora:F2}\n");
    Console.WriteLine("--------- DIGITE A OPÇÃO DESEJADA ---------");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo (Cálculo da Cobrança)");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("9 - Sair do Programa");
    Console.WriteLine("-------------------------------------------\n");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "9":
            exibirMenu = false;
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção Inválida, tente novamente :(");
            Console.ForegroundColor = ConsoleColor.White;

            break;
    }

    Console.WriteLine("Pressione ENTER para continuar!");
    Console.ReadLine();
}

Console.WriteLine("---- PROGRAMA FOI ENCERRADO, ATÉ BREVE ----\n");