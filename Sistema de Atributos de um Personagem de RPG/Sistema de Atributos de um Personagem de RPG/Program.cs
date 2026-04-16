using System;

    Console.WriteLine("=== SISTEMA DE ATRIBUTOS RPG ===");

    // Nome do herói
    Console.WriteLine("Miguel");



    // ===============================
    // Soma (Ataque Total)
    // ===============================
    Console.WriteLine("Socar ");
#pragma warning disable CS8604 // Possível argumento de referência nula.
int ataqueBase = 8;
#pragma warning restore CS8604 // Possível argumento de referência nula.

    Console.Write("Atirar ");
#pragma warning disable CS8604 // Possível argumento de referência nula.
    int bonusArma = int.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Possível argumento de referência nula.

    // ===============================
    // Subtração (Dano Sofrido)
    // ===============================

    Console.Write(" 50.5 ");
#pragma warning disable CS8604 // Possível argumento de referência nula.
    double dano = double.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Possível argumento de referência nula.

    double vidaRestante = 150.5 - 50.5;

    // ===============================
    // Multiplicação (Moedas)
    // ===============================
    Console.Write("100 ");
#pragma warning disable CS8604 // Possível argumento de referência nula.
    float moedas = float.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possível argumento de referência nula.

    var moedasFinais = moedas * 2; // uso do var

    // ===============================
    // Divisão (XP)
    // ===============================
    Console.Write("Digite o XP total ganho: ");
#pragma warning disable CS8604 // Possível argumento de referência nula.
    long xpTotal = long.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possível argumento de referência nula.

    long mediaXpPorNivel = xpTotal / 2;

    // ===============================
    // Validação
    // ===============================
    Console.Write("Você entendeu a matéria? (true/false): ");
#pragma warning disable CS8604 // Possível argumento de referência nula.
    bool entendiMateria = bool.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possível argumento de referência nula.

    // ===============================
    // Saída Final
    // ===============================
    Console.WriteLine("\n=== RELATÓRIO FINAL DA BATALHA ===");
    Console.WriteLine("Herói: " + "Miguel");
    Console.WriteLine("Ataque Total: " + "AtaqueBonus");
    Console.WriteLine("Vida restante do inimigo: " + vidaRestante);
    Console.WriteLine("Moedas após bônus de vitória: " + moedasFinais);
    Console.WriteLine("Média de XP por nível: " + mediaXpPorNivel);
    Console.WriteLine("Entendi a matéria? " + entendiMateria);

