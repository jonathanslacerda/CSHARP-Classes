using System;

namespace Condicionais {

    static class Condicionais {

        static void Main(string[] args) {

            PedraPapelTesoura("pedra", "papel");
            ParImpar(2, 2);
            Domino(2, 2);
            DominoPt2(0);
            Peneira(180);
        }

        static void PedraPapelTesoura(string jogada1, string jogada2) {

            if (jogada1 == "pedra" && jogada2 == "tesoura" || jogada1 == "tesoura" && jogada2 == "pedra") {
                Console.WriteLine("PEDRA");
            } else if (jogada1 == "pedra" && jogada2 == "papel" || jogada1 == "papel" && jogada2 == "pedra") {
                Console.WriteLine("PAPEL");
            } else if (jogada1 == "tesoura" && jogada2 == "papel" || jogada1 == "papel" && jogada2 == "tesoura") {
                Console.WriteLine("TESOURA");
            } else if (jogada1 == jogada2) {
                Console.WriteLine("EMPATE");
            };

        }


        static void ParImpar (int jogada1, int jogada2) {

            if ((jogada1 + jogada2) % 2 == 0) {
                Console.WriteLine("PAR");
            } else {
                Console.WriteLine("ÍMPAR");
            };

        }


        static void Domino (int ladoA, int ladoB) {

            if (ladoA == ladoB) {
                Console.WriteLine("SIM");
            } else {
                Console.WriteLine("NÃO");
            };

        }

        static void DominoPt2 (int bucha) {

            switch(bucha) {
                case 1: Console.WriteLine("Bucha de Ás"); break;
                case 2: Console.WriteLine("Bucha de Duque"); break;
                case 3: Console.WriteLine("Bucha de Terno"); break;
                case 4: Console.WriteLine("Bucha de Quadra"); break;
                case 5: Console.WriteLine("Bucha de Quina"); break;
                case 6: Console.WriteLine("Bucha de Sena"); break;
                default : Console.WriteLine("Bucha de Branco"); break;
            }

        }


        static void Peneira(int altura) {

            if (altura >= 180) {
                Console.WriteLine("APROVADO");
            } else {
                Console.WriteLine("REPROVADO");
            }

        }

        static void PosicoesVolei(int altura) {

            if(altura < 180) {
                Console.WriteLine("REPROVADO");
            } else if (altura >= 180 && altura < 185) {
                Console.WriteLine("LÍBERO");
            } else if (altura > 185 && altura <= 195) {
                Console.WriteLine("PONTEIRO");
            } else if (altura > 195 && altura <= 205) {
                Console.WriteLine("OPOSTO");
            } else {
                Console.WriteLine("CENTRAL");
            }


        }

    }
    
}
