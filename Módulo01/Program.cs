using System;

namespace Program {

    static class Program {

        static void Main(string[] args) {

            Console.WriteLine("Hello World");
            CalculadoraIMC();
            Conversor();
            CalcularDesconto();
            JurosCompostos();
            DistanciaEntreDoisPontos();

        }


        static void CalculadoraIMC() {

            double peso = 136.5;
            double altura = 1.84;

            double imc = peso / Math.Pow(altura, 2);

            Console.WriteLine("IMC é igual à: " + imc);

        }


        static void Conversor() {

            double fahrenheit = 73;

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine(fahrenheit + "°F é equivalente à " + celsius + "°C");

        }


        static void CalcularDesconto() {

            double valorTotal = 110;
            double meuDinheiro = 50;
            double valorDesconto = valorTotal - meuDinheiro;

            double desconto = (valorDesconto * 100) / valorTotal;

            Console.WriteLine("O valor percentual de desconto é de: " + desconto);

        }



        static void JurosCompostos() {

            double capital = 1000;
            double taxaJuros = 0.125;
            double tempoEmMeses = 5;

            double jurosCompostos = capital * (Math.Pow(1 + taxaJuros, tempoEmMeses));
            
            Console.WriteLine("O Montante é de: " + "R$ " + jurosCompostos);

        }


        static void DistanciaEntreDoisPontos() {

            double x1 = 1;
            double x2 = 1;
            double y1 = 1;
            double y2 = 4;

            double calcularDistancia = 
            Math.Sqrt(Math.Pow(x2 - x1, 2) + 
            Math.Pow(y2 - y1, 2));

            Console.WriteLine("A distância entre dois pontos é: " + calcularDistancia);

        }


        static void VelocidadeMedia() {

            // distância em metros
            int distPercorrida = 500;
            // tempo em segundos
            int tempo = 10;

            // velocidade em metros / seg
            double velocidadeMtS = distPercorrida / tempo;

            // velocidade em km/h
            double velocidadeKmH = velocidadeMtS * 3.6;

            Console.WriteLine("Velocidade em Km/h é: " + velocidadeKmH);


        }
    }
}
