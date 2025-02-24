// Faça um programa que entre com 10 notas de cada aluno de uma turma de 20 alunos e imprima:
//• A média de cada aluno;
//• A média da turma;
//• O percentual de alunos que tiveram médias maiores ou iguais a 5.

List<double> notas = new List<double>();

int totalalunos = 20;

void @for();
{
    for (int x = 1; x <= 20; x++)
    {
        Console.WriteLine($"Digite o nome do {x}º aluno: ");
        string nomealuno = Console.ReadLine();

        for (int y = 1; y <= 10; y++)
        {
            Console.WriteLine($"Digite a {y}ª nota: ");
            double nota = int.Parse(Console.ReadLine());
            notas.Add(nota);
        }
    }
}