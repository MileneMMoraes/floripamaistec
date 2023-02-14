// Semana 01 - Exercício 2

List<string> frutas = new List<string>();
bool continuar = true;

while (continuar)
{
    if (frutas.Count() == 15)
    {
        continuar = false;
        break;
    }

    Console.Write("Digite o nome de uma fruta: ");
    frutas.Add(Console.ReadLine());
    Console.Write("Você deseja continuar? ");
    string resposta = Console.ReadLine();

    if (resposta == "nao" || resposta == "n" || resposta == "não")
    {
        continuar = false;
    }
}

frutas.Sort();

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}

