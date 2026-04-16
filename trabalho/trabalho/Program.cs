Console.OutputEncoding = System.Text.Encoding.UTF8;

//Variáveis
int escolhaJogador = 0, escolhaCpu = 0;
int pontosJogador = 0, pontosCpu = 0;
string nomeJogador = "";
string nomeCpu = "";

Random sorteio = new Random();

Console.WriteLine("⚖  O CÍRCULO DO EQUILÍBRIO ⚖\n");

//História
Console.WriteLine("No mundo de Sincronia existiam três grandes clãs elementais.");
Console.WriteLine("Cada um representava um poder importante para manter o equilíbrio.\n");

Console.WriteLine("⛰️ Clã da Montanha (Pedra) - guerreiros fortes e resistentes.");
Console.WriteLine("📜 Clã do Pergaminho (Papel) - estrategistas sábios e inteligentes.");
Console.WriteLine("🪒 Clã da Lâmina (Tesoura) - lutadores rápidos e precisos.\n");

Console.WriteLine("Durante muito tempo o Grande Árbitro manteve a paz entre os clãs.");
Console.WriteLine("Mas um dia ele desapareceu...");
Console.WriteLine("Sem ele, os clãs começaram a duelar para decidir quem governará Sincronia.\n");

Console.WriteLine("Você é um Aprendiz do Destino.");
Console.WriteLine("Seu desafio é enfrentar o Vazio e tentar restaurar o equilíbrio do mundo.\n");

Console.WriteLine("Escolha seu poder:");
Console.WriteLine("1 - Pedra 🪨");
Console.WriteLine("2 - Papel 📝");
Console.WriteLine("3 - Tesoura ✂️");


//Jogo continua até alguém ganhar 2 rodadas
while (pontosJogador < 2 || pontosCpu < 2)
{
    Console.Write("\nEscolha seu poder: ");
    int.TryParse(Console.ReadLine(), out escolhaJogador);

    escolhaCpu = sorteio.Next(1, 4);

    //Nome das escolhas
    if (escolhaJogador == 1) nomeJogador = "Pedra 🪨";
    if (escolhaJogador == 2) nomeJogador = "Papel 📝";
    if (escolhaJogador == 3) nomeJogador = "Tesoura ✂️";

    if (escolhaCpu == 1) nomeCpu = "Pedra 🪨";
    if (escolhaCpu == 2) nomeCpu = "Papel 📝";
    if (escolhaCpu == 3) nomeCpu = "Tesoura ✂️";

    Console.WriteLine("Você escolheu: " + nomeJogador);
    Console.WriteLine("O Vazio escolheu: " + nomeCpu);

    if (escolhaJogador == escolhaCpu)
    {
        Console.WriteLine("Empate! As energias se anulam.");
    }

    if (escolhaJogador == 1 && escolhaCpu == 3 ||
        escolhaJogador == 2 && escolhaCpu == 1 ||
        escolhaJogador == 3 && escolhaCpu == 2)
    {
        Console.WriteLine("Boa jogada! Você venceu a rodada.");
        pontosJogador++;
    }

    if (escolhaCpu == 1 && escolhaJogador == 3 ||
        escolhaCpu == 2 && escolhaJogador == 1 ||
        escolhaCpu == 3 && escolhaJogador == 2)
    {
        Console.WriteLine("O Vazio venceu essa rodada.");
        pontosCpu++;
    }

    Console.WriteLine("Placar: Você " + pontosJogador + " x " + pontosCpu + " Vazio");
}


//Resultado final
if (pontosJogador > pontosCpu)
{
    Console.WriteLine("\nVocê venceu o duelo!");
    Console.WriteLine("O equilíbrio de Sincronia foi restaurado.");
    Console.WriteLine("Parabéns! Você arrasou, que orgulho 😝");
}

if (pontosCpu > pontosJogador)
{
    Console.WriteLine("\nParabéns... você perdeu e o vazio ganhou.");
    Console.WriteLine("Você só tinha um dever, que decepção 😤");
}
