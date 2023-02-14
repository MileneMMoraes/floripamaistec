// Semana 1 -  Exercício 1

int[] numeros = new int[10];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < numeros.Length; i++)
{
    int contador = 1;

    for (int j = 1; j < numeros[i]; j++)
    {
        if (numeros[i] % j == 0)
        {
            contador++;
        }
    }

    if (contador == 2)
    {
        Console.WriteLine($"O número {numeros[i]} é um numero primo e está na posição {i}.");
    }
}
