using System.Collections;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Runtime.Serialization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
int n1 = lerNumero();
int n2 = lerNumero();

Console.WriteLine("Soma:" + soma(n1, n2));
Console.WriteLine("Subtração:" + subtracao(n1, n2));
Console.WriteLine("Multiplicacao:" + multiplicacao(n1, n2));
Console.WriteLine("Divisao:" + divisao(n1, n2));


int soma(int a, int b)
{
    return a + b;
}

int subtracao(int a, int b)
{
    return a - b;
}

int multiplicacao(int a, int b)
{
    return a * b;
}

int divisao(int a, int b)
{
    return a / b;
}

int lerNumero()
{
    Console.Write("Digite o número: ");
    if (int.TryParse(Console.ReadLine()!, out int n))
    {
        return n;
    }
    else
    {
        return 0;
    }
}
































//lancarMagia();
//menu();
//int.TryParse(Console.ReadLine()!, out int escolha);
//switch(escolha){
//    case 1:
//        Console.WriteLine("I don't like P Diddy");
//        break;
//     case 2:
//        Console.WriteLine("Expresso is my favorite song");
//        break;
//    case 3:
//        Console.WriteLine("You're no uniform. Goes to Directory now!!!");
//        break;
//    case 4:
//        Console.WriteLine("Calorias são unidades de medida, " +
//            "que são responsáveis por medir a energia no corpo humano." +
//            "As calorias, podem ser convertidas em Joules, " +
//            "e também em volts." +
//            " As calorias vem dos carboidratos, oriundos da quebra da glicose no ciclo ácido cítrico " +
//            "e na cadeia transportadora de elétrons");
//        break;
//}

//int menu()
//{
//    Console.WriteLine("Bem vindo! Digite - 1 Justin Bieber" +
//        "\n2 - Sabrina Carpinter\n3 - Marcio\n4 - Lucia");
//    if (int.TryParse(Console.ReadLine()!, out int escolha))
//    {
//        return escolha;
//    }
//    {
//        return 0;
//    }
//}

//void lancarMagia()
//{
//    Console.WriteLine("Bem vindo ao mundo da magia🪄");
//}
