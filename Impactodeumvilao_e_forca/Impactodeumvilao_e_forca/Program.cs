using System;
using System.ComponentModel.Design;
class Program
{
    static void Main()
    {
        Console.WriteLine("O impiedoso vilão repleto de luxúria e maldade LUX@S está tentando invadir o seu castelo.\nEle tentará por três vezes causar impacto no portão com sua tecnologia conhecida como PORRA");
        int tentativas = 3;
        bool venceu = false;

        for (int i = 1; i <= tentativas; i++)
        {
            Console.WriteLine($"Tentativa {i} - Digite a força:");
            double forca = Convert.ToDouble(Console.ReadLine());

            double resultado = Math.Pow(forca, 3);

            Console.WriteLine($"Força elevada ao cubo: {resultado:F2}");

            if (resultado > 400)
            {
                Console.WriteLine("Você conseguiu defender seu reino!");
                venceu = true;
                break;
            }
            else
            {
                Console.WriteLine("A força não foi suficiente...");

            }
        }
        if (!venceu)
            Console.WriteLine("Você perdeu e o castelo foi invadido.Você passará o resto da vida servindo ao LUX@S sucumbindo aos seus desejos com dores no corpo para o resto da vida");

            }
        }
    
