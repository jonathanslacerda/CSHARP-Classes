using System;
using Microsoft.VisualBasic;

namespace Condicionais {

    static class Condicionais {

        static void Main(string[] args) {

            PedraPapelTesoura("pedra", "papel");
            ParImpar(2, 2);
            Domino(2, 2);
            DominoPt2(0);
            Peneira(180);
            ImpostoRenda(false, false, 1000000);
            RollerCoaster(19, false, 180, false);
            NotasConceito(9);
            Caracteres("A", 1);
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

        static void ImpostoRenda(bool aposentado, bool portadorDoenca, double rendimento) {

            if (aposentado == true || portadorDoenca == true) {
                Console.WriteLine("ISENTA");
            } else if (rendimento <= 2855970) {
                Console.WriteLine("VAZA LEÃO! JÁ TÁ DIFÍCIL SEM VOCÊ");
            } else {
                Console.WriteLine("PEGA LEÃO");
            }


        }


        static void RollerCoaster(int idade, bool doencaCardiaca, int altura, bool estudante) {


            if (idade < 12 || idade > 65 || doencaCardiaca == true || altura < 150) {
                Console.WriteLine("ACESSO NEGADO");
            } else if (idade > 12 || idade < 18 || estudante == true) {
                Console.WriteLine("VALOR DA ENTRADA: R$ 10,00");
            } else {
                Console.WriteLine("VALOR DA ENTRADA: R$ 20,00");
            }


        }


        static void NotasConceito (double nota) {
            

            if (nota >= 9) {
                Console.WriteLine("A");
            } else if (nota >= 8) {
                Console.WriteLine("B");
            } else if (nota >= 6) {
                Console.WriteLine("C");
            } else if (nota >= 4) {
                Console.WriteLine("D");
            } else {
                Console.WriteLine("E");
            }


        }


        static void Caracteres (string caracter, int numero) {


            if (caracter == "A" || caracter == "E" || caracter == "I" || caracter == "O" || caracter == "U") {
                Console.WriteLine("Vogal Maiúscula");
            } else if (caracter == "a" || caracter == "e" || caracter == "i" || caracter == "o" || caracter == "u") {
                Console.WriteLine("Vogal Minúscula");
            } else if (numero == 0 || numero == 1 || numero == 2 || numero == 3 || numero == 4 || numero == 5 || numero == 6 || numero == 7 || numero == 8 || numero == 9) {
                Console.WriteLine("Numeral");
            } else {
                Console.WriteLine("Consoante");
            }




        }

    }
    
}
 