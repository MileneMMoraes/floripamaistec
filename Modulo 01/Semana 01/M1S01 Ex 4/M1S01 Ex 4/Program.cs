// Semana 1 - Exercício 4

string[] nomesAlunos = new string[5];
decimal[] mediasAlunos = new decimal[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o nome do {i + 1}º aluno: ");
    nomesAlunos[i] = Console.ReadLine();

    Console.Write($"Digite a média do {i + 1}º aluno: ");
    mediasAlunos[i] = decimal.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    if (mediasAlunos[i] >= 6)
    {
        Console.WriteLine($"O aluno {nomesAlunos[i]} está APROVADO");
    }
    else
    {
        Console.WriteLine($"O aluno {nomesAlunos[i]} está REPROVADO");
    }
}
