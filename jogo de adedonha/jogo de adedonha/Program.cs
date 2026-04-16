using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Random random = new Random();
        char letra = (char)random.Next('A', 'Z' + 1);

        Console.WriteLine("=== JOGO: ADEDONHA ===");
        Console.WriteLine("Você está participando de um torneio de palavras no reino medieval de Valdoria.");
        Console.WriteLine("O mago do reino escolheu uma letra mágica.");
        Console.WriteLine("Para vencer, você precisa escrever uma palavra que comece com essa letra.");
        Console.WriteLine();

        Console.WriteLine("Letra sorteada: " + letra);
        Console.Write("Digite uma palavra: ");

        string palavra = Console.ReadLine();

        if (!string.IsNullOrEmpty(palavra) && char.ToUpper(palavra[0]) == letra)
        {
            Console.WriteLine("🎉 Boa! Sua palavra começa com a letra correta!");
        }
        else
        {
            Console.WriteLine("❌ Sua palavra não começa com a letra " + letra);
        }
    }
}