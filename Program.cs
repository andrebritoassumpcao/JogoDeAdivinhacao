using System;

namespace JogoDeAdivinhacao {
    class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int pontuacaoTotal = 0;
            bool tentarNovamente = true;

            while (tentarNovamente) { 
                int numeroAleatorio = random.Next(1, 101);
                int numeroTentativas = 0;
                int palpite = 0;

                Console.WriteLine("Bem-vindo! Esse é o jogo de advinhação, boa sorte!!");
                Console.WriteLine("Digite aqui um número entre 0 e 100:");

                while (palpite != numeroAleatorio) {
                    numeroTentativas++;

                    palpite = int.Parse(Console.ReadLine());

                    if (palpite == numeroAleatorio) {
                        Console.WriteLine("Uaaauu, meus parabéns você acertou!!");
                        Console.WriteLine("Suas tentativas: " + numeroTentativas);

                        pontuacaoTotal += (10 - numeroTentativas);
                        Console.WriteLine($"Sua pontuação nesta rodada é: {10 - numeroTentativas}");

                        Console.WriteLine("Deseja jogar novamente? (s/n)");
                        tentarNovamente = Console.ReadLine().ToLower() == "s";

                    } else if (palpite > numeroAleatorio) {
                        Console.WriteLine("Hmm, quase!! O número certo é menor!");
                    } else {
                        Console.WriteLine("Hmm, quase!! O número certo é maior!");
                    }
                }

                if (!tentarNovamente) {
                    Console.WriteLine($"Sua pontuação total é: {pontuacaoTotal}");
                }
            }

            Console.WriteLine("Obrigado por jogar!");
            Console.ReadKey();
        }
    }
}
