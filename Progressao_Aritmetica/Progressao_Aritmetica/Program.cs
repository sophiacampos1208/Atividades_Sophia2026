Console.OutputEncoding= System.Text.Encoding.UTF8;
Console.Write("Digite o primeiro termo da progressão aritmética: ");
int primeiro = int.Parse(Console.ReadLine());

Console.Write("Digite a razão da progressão aritmética: ");
int razao = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de termos da progressão aritmética: ");
int quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("\nProgressão Aritmética:");

for (int i = 1; i < quantidade ; i++)
{
 int termo = primeiro + (i - 1) * razao;
    Console.Write($"{termo}➡️");
}   
Console.WriteLine("🎯");
/*
 saída 
1➡️ 2➡️ 3➡️ 4➡️ 5➡️ 6➡️ 7
 */