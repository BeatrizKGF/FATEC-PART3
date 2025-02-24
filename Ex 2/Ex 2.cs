// Num campeonato de futebol, se inscreveram 30 países. Sabendo-se que na lista oficial de cada país consta, além de outros dados, peso e idade de 12 jogadores.
// Faça um programa que apresente as seguintes informações:
// • Peso médio e a idade média de cada um dos times;
// • Peso médio e a idade média de todos os participantes.

using System.Runtime.Serialization;

int somaidade = 0;
double somapeso = 0;

int somaidadetime = 0;
double somapesotime = 0;

int jogadores = 12;
int paises = 30;

//void @for()
//{
//    for (int x = 1; x <= 30; x++)
//    {
//        Console.WriteLine($"Digite o nome do {x}º país: ");
//        string nomepais = Console.ReadLine();

//        for (int y = 1; y <= 12; y++)
//        {
//            Console.WriteLine($"Digite a idade do {y}º jogador do país {nomepais} em anos: ");
//            int idade = int.Parse(Console.ReadLine());
//            somaidade += idade;

//            Console.WriteLine($"Digite o peso do {y}º jogador do país {nomepais} em kg: ");
//            double peso = int.Parse(Console.ReadLine());
//            somapeso += peso;
//        }

//        Console.WriteLine($"A média de idade dos jogadores deste time é {somaidade / jogadores} anos.");
//        Console.WriteLine($"A média de peso dos jogadores deste time é {somapeso / jogadores} kg.");
//        Console.WriteLine();
//    }

//    Console.WriteLine($"A média de idade dos jogadores de todos os países é {somaidade / (paises * jogadores)} anos.");
//    Console.WriteLine($"A média de peso dos jogadores de todos os países é {somapeso / (paises * jogadores)} kg.");
//}

//void @while()
//{
//    int x = 1;

//    while (x <= 30)
//    {
//        Console.WriteLine($"Digite o nome do {x}º país: ");
//        string nomepais = Console.ReadLine();

//        int y = 1;

//        while (y <= 12)
//        {
//            Console.WriteLine($"Digite a idade do {y}º jogador do país {nomepais} em anos: ");
//            int idade = int.Parse(Console.ReadLine());
//            somaidade += idade;

//            Console.WriteLine($"Digite o peso do {y}º jogador do país {nomepais} em kg: ");
//            double peso = int.Parse(Console.ReadLine());
//            somapeso += peso;

//            y++;
//        }

//        Console.WriteLine($"A média de idade dos jogadores deste time é {somaidade / jogadores} anos.");
//        Console.WriteLine($"A média de peso dos jogadores deste time é {somapeso / jogadores} kg.");
//        Console.WriteLine();
//        x++;
//    }

//    Console.WriteLine($"A média de idade dos jogadores de todos os países é {somaidade / (paises * jogadores)} anos.");
//    Console.WriteLine($"A média de peso dos jogadores de todos os países é {somapeso / (paises * jogadores)} kg.");
//}

void @doWhile()
{
    int x = 1;

    do
    {
        Console.WriteLine($"Digite o nome do {x}º país: ");
        string nomepais = Console.ReadLine();

        int y = 1;

        do
        {
            Console.WriteLine($"Digite a idade do {y}º jogador do país {nomepais} em anos: ");
            int idade = int.Parse(Console.ReadLine());
            somaidade += idade;

            Console.WriteLine($"Digite o peso do {y}º jogador do país {nomepais} em kg: ");
            double peso = int.Parse(Console.ReadLine());
            somapeso += peso;

            y++;
        } while (y <= 12);

        Console.WriteLine($"A média de idade dos jogadores deste time é {somaidade / jogadores} anos.");
        Console.WriteLine($"A média de peso dos jogadores deste time é {somapeso / jogadores} kg.");
        Console.WriteLine();
        x++;

    } while (x <= 30);

    Console.WriteLine($"A média de idade dos jogadores de todos os países é {somaidade / (paises * jogadores)} anos.");
    Console.WriteLine($"A média de peso dos jogadores de todos os países é {somapeso / (paises * jogadores)} kg.");
}

////@for();
////Console.WriteLine();

//@while();
//Console.WriteLine();

@doWhile();
Console.WriteLine();

Console.ReadKey();