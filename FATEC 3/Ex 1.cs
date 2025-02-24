// Faça um programa que exiba na tela a tabuada de multiplicação dos números de 1 a x. OBS.: x é o valor a ser digitado pelo usuário.

Console.WriteLine("Digite um número (intervalo) para exibição da tabuada: ");
int number = int.Parse(Console.ReadLine());

void @for (int a)
{
    for (int x = 1; x <= number; x++)
    {
        Console.Write($"Tabuada {x}: \t");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{x * i} \t");
        }
        Console.WriteLine();
    }
}

void @while (int a)
{
    int x = 1;
    while (x <= number)
    {
        Console.Write($"Tabuada {x}: \t");
        int i = 1;
        while (i <= 10)
        {
            Console.Write($"{x * i} \t");
            i++;
        }
        Console.WriteLine();
        x++;
    }
}

void @doWhile (int a)
{
    int x = 1;
    do
    {
        Console.Write($"Tabuada {x}: \t");
        int i = 1;
        do
        {
            Console.Write($"{x * i} \t");
            i++;
        } while (i <= 10);
        Console.WriteLine();
        x++;
    } while (x <= number);
}

@for(number);
Console.WriteLine();

@while(number);
Console.WriteLine();

@doWhile(number);
Console.WriteLine();

Console.ReadKey();