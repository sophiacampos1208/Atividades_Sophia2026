class Program
{



    static void Main ()
    {
        Console.WriteLine("O astuto ancião conhecido como Mythrandir está precisando calcular a área de sua magia.\n O cálculo da sua magia é a área de um triângulo equilátero\n(Lembrando: Um triângulo equilátero tem todos os lados iguais)");
        Console.WriteLine("Digite o valor do lado do triângulo");
        double lado = Convert.ToDouble(Console.ReadLine());

    double area = (lado * lado * Math.Sqrt(3)) / 4;

    Console.WriteLine("Área:" + area.ToString("F2"));
    }
}


