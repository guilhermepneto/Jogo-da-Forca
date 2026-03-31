//JOGO DA FORCA

Console.WriteLine("---------------------------------");
Console.WriteLine("BEM VINDO AO JOGO DA FORCA");
Console.WriteLine("---------------------------------");
Console.WriteLine("Quando estiver pronto, pressione ENTER para iniciar o jogo!");
Console.ReadLine();

string palavra_secreta = "ABACATE";

char[] letras_corretas = new char[7];

for (int contador_letras = 0; contador_letras < 7; contador_letras++)
{
    letras_corretas[contador_letras] = '_';
}

int contador_erros = 0;

bool acerto = false;
bool perdeu = false;

while (!acerto && !perdeu)
{
    Console.Clear();
    Console.WriteLine("Letras erradas: " + contador_erros);
    Console.Write("Tentativas: ");

    for (int contador_letras = 0; contador_letras < 7; contador_letras++)
    {
        Console.Write(letras_corretas[contador_letras]);
    }

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
    {
        acerto = true;
        Console.WriteLine($"Parabéns, você descobriu a palavra secreta :D");
        Console.WriteLine("Total de letras erradas foram: " + contador_erros);
    }

    if (contador_erros > 5)
    {
        Console.WriteLine("Infelizmente você não tem mais tentativas :(");
        perdeu = true;
    }
}

Console.ReadLine();
