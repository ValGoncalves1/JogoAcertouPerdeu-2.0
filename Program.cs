using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroOculto = random.Next(0,98);
        int tentativas = 0;
        int jogadores;
        int jogadorAtual = 1;

        Console.WriteLine("Bem-vindo ao jogo Acertou: Perdeu!");
        Console.Write("Quantos jogadores irão participar? ");
        jogadores = int.Parse(Console.ReadLine());

        while (true)
        {
            Console.WriteLine($"Jogador {jogadorAtual}, é sua vez!");
            Console.Write("Digite seu palpite: ");
            int palpite = int.Parse(Console.ReadLine());
            tentativas++;

            if (palpite == numeroOculto)
            {
                Console.WriteLine($"Jogador {jogadorAtual} acertou! Você precisou de {tentativas} tentativas.");
                break;
            }
            else if (palpite < numeroOculto)
            {
                Console.WriteLine("Mais alto!");
            }
            else
            {
                Console.WriteLine("Mais baixo!");
            }

            jogadorAtual = (jogadorAtual % jogadores) + 1;
        }
    }
}
