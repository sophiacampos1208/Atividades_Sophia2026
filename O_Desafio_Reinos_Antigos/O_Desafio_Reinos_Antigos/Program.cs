// See https://aka.ms/new-console-template for more information
//Perguntas que o programa fará para o jogador
using System.ComponentModel.Design;
using System.Runtime;
bool podeatacar = false;

Console.WriteLine("Escreva o nome do herói:");
string nome = Console.ReadLine();

Console.WriteLine("Escreva a classe do herói (Mago,Clérigo,Guerreiro,Druida,Anão,Elfo ou Troll):");
string classe = Console.ReadLine();

Console.WriteLine("Escreva o nível do herói:");
int.TryParse(Console.ReadLine(), out int nivel);

Console.WriteLine("Escreva os pontos de vida do herói (HP):");
double.TryParse(Console.ReadLine(), out double hp);

Console.WriteLine("Escreva os pontos de magia do herói (mana):");
int.TryParse(Console.ReadLine(), out int mana);

Console.WriteLine("Escreva a quantidade do ouro na mochila do herói:");
double.TryParse(Console.ReadLine(), out double ouro);

//1.Regra da raça inimiga (uso do != e !)
//O herói não passa se não for Troll e o nível não for menor que 5
if (classe != "Troll" && !(nivel < 5))
{
    Console.WriteLine("Bem-vindo à guilda!" +  nome);

    //2.Calculo do poder de combate
    double poderbase = nivel * 10 + hp / 2 - 5;
    Console.WriteLine("Seu poder Base é:" + poderbase);

    //3. Regra do dano critico (uso de % e ==)
    if (poderbase % 2 == 0) ;
    {
        Console.WriteLine("Ataque Critico! Os deuses do combate sorriem para você");

    }

    if (classe == "mago" || classe == "Druida" || classe == "Clérigo")
    {
        if (mana >= 30 && nivel <= 100)
        {
            Console.WriteLine("magia canalizada com sucesso");
        }
    }
    else
    {
        Console.WriteLine("O cajado falhou! Sem mana ou nivel instavel.");
    }

}
else if (classe == "Guerreiro" || classe == "Anão" || classe == "Elfo")
{
    int poderbase = 0;
    if (hp > 20 && poderbase > 50)
    {
        podeatacar = true;
        Console.WriteLine("Lamina afiada! ataque fisico autorizado.");
    }

}

//5. Suborno ao dragão (caso não possa atacar)
if (podeatacar)
{
    Console.WriteLine("Resultado: {nome} enfrentou o dragão e sobreviveu");
}
else
{
    Console.WriteLine("\n Você não está apto para o combate direto..");
    if (ouro > 1000 || classe == "Anão")
    {
        Console.WriteLine("O dragão aceitou o suborno! você fugiu com vida.");
    }
    else
    {
        Console.WriteLine("CHURRASCO! O dragão não aceitou negociar.");
    }
}
