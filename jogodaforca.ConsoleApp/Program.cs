//JOGO DA FORCA

using System.Security.Cryptography;

while (true)
{
    Console.Clear();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("BEM VINDO AO JOGO DA FORCA");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Quando estiver pronto, pressione ENTER para iniciar o jogo!");
    Console.ReadLine();


    string[] palavras = [
        "ABACATE",
        "ABACAXI",
        "ACEROLA",
        "ACAI",
        "ARACA",
        "BACABA",
        "BACURI",
        "BANANA",
        "CAJA",
        "CAJU",
        "CARAMBOLA",
        "CUPUACU",
        "GRAVIOLA",
        "GOIABA",
        "JABUTICABA",
        "JENIPAPO",
        "MACA",
        "MANGABA",
        "MANGA",
        "MARACUJA",
        "MURICI",
        "PEQUI",
        "PITANGA",
        "PITAYA",
        "SAPOTI",
        "TANGERINA",
        "UMBU",
        "UVA",
        "UVAIA"
    ];

    int num_aleatorio = RandomNumberGenerator.GetInt32(palavras.Length);

    string palavra_secreta = palavras[num_aleatorio];

    char[] letras_corretas = new char[palavra_secreta.Length];

    for (int contador_letras = 0; contador_letras < palavra_secreta.Length; contador_letras++)
    {
        letras_corretas[contador_letras] = '_';
    }

    int contador_erros = 0;

    bool acerto = false;
    bool perdeu = false;

    while (true)
    {
        Console.Clear();
        Console.WriteLine("Letras erradas: " + contador_erros);
        Console.Write("Tentativas: ");

        for (int contador_letras = 0; contador_letras < palavra_secreta.Length; contador_letras++)
        {
            Console.Write(letras_corretas[contador_letras]);
        }

        Console.WriteLine("\n-----------------------------");

        if (contador_erros == 0)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");

        }
        else if (contador_erros == 1)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");

        }
        else if (contador_erros == 2)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |         |        ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }
        else if (contador_erros == 3)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |        /|        ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }
        else if (contador_erros == 4)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |        /|\       ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }
        else if (contador_erros == 5)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |        /|\       ");
            Console.WriteLine(@" |        / \       ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }
        else if (contador_erros == 6)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |        /|\       ");
            Console.WriteLine(@" |        / \       ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }

        if (acerto)
        {
            Console.WriteLine($"Parabéns, você descobriu a palavra secreta :D");
            Console.WriteLine("Total de letras erradas foram: " + contador_erros);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
        else if (perdeu)
        {
            Console.WriteLine("Infelizmente você não tem mais tentativas :(, a palavra era: " + palavra_secreta);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
        if (acerto || perdeu)
            break;

        Console.Write("\nDigite uma letra: ");
        char chute = Convert.ToChar(Console.ReadLine());

        bool letra_encontrada = false;

        for (int contador_palavra = 0; contador_palavra < palavra_secreta.Length; contador_palavra++)
        {
            char letra_atual = palavra_secreta[contador_palavra];

            if (chute == letra_atual)
            {
                letras_corretas[contador_palavra] = chute;
                letra_encontrada = true;
            }
        }

        if (!letra_encontrada)
            contador_erros++;

        string letras_corretas_completa = string.Join("", letras_corretas);

        if (letras_corretas_completa == palavra_secreta)
            acerto = true;

        if (contador_erros > 5)
            perdeu = true;

    }
    Console.WriteLine("Deseja jogar novamente? Pressione S para continuar ou N para sair...");
    string continuar = Console.ReadLine();

    if (continuar != "S" && continuar != "s")
    {
        Console.WriteLine("Muito obrigado por jogar!");
        break;
    }

}

Console.ReadLine();
