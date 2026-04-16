using System.Net.Http.Headers;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Cálculo de Média");

float n = 0;
float soma = 0;
int cont = 0;

while (true)
{
    Console.WriteLine($"Digite o N{cont + 1}:");
    float.TryParse(Console.ReadLine()!.Replace(".", ","), out n);

    soma += n;
    cont++;

    Console.Write("Quer sair do Programa [S/N]: ");
    string sair = Console.ReadLine()!.ToLower()!;

    while (sair != "s" && sair != "n")
    {
        Console.Write("Digite somente [S/N]: ");
        sair = Console.ReadLine()!.ToLower()!;
    }

    if (sair == "s")
    {
        break;
    }
}

// Cálculo da média
if (cont > 0)
{
    float media = soma / cont;
    Console.WriteLine($"\nQuantidade de números: {cont}");
    Console.WriteLine($"Média: {media}");
}
else
{
    Console.WriteLine("Nenhum número foi digitado.");
}
