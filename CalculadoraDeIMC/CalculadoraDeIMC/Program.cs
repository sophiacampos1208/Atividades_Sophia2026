Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Vamos calcular o seu IMC 🏋");
double peso, altura, imc;
Console.Write("Digite o seu peso (kg):".Replace(",","."));
peso = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a sua altura (m):".Replace(",", "."));
altura = Convert.ToDouble(Console.ReadLine());
imc = peso / Math.Pow(altura, 2);
Console.WriteLine("\nSeu IMC é:"+ imc.ToString("F2"));
if (imc < 18.5 )
{
    Console.WriteLine("Classificação: Abaixo do peso😐");
}
else if (imc <= 24.9 )
{
    Console.WriteLine("Classificação: Peso Normal😊");
}
else if ( imc <= 29.9)
{
    Console.WriteLine("Classificação: Sobrepeso😕");
}
else if (imc <= 39.9 )
{
    Console.WriteLine("Classificação: Obesidade😔");
}
else if ( imc > 40)
{
    Console.WriteLine("Classificação: Obesidade Grave😟");
}
    Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();
