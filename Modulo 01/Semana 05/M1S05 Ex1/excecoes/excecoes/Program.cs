decimal numero1, numero2, resultado;
try
{
    Console.WriteLine("Digite um número decimal: ");
    numero1 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Digite outro número decimal: ");
    numero2 = decimal.Parse(Console.ReadLine());

    resultado = numero1 / numero2;

    Console.WriteLine($"O resultado de {numero1} / {numero2} é: {resultado}.");
}
catch(DivideByZeroException ex)
{
    Console.WriteLine("Não é possível dividir por zero.");
}
catch (FormatException ex)
{
    Console.WriteLine("Letras não podem ser informadas, informe números");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro capturado: {ex}.");
}
finally //Finalmente
{
    numero1 = 0;
    numero2 = 0;
}