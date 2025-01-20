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
            COVID19();
            Pi();
            Poligonos();
            Delta();
            VolumeEsfera();

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


        static void COVID19() {

            int populacaoInicial = 1000;
            int potencialInfeccao = 4;
            // Tempo decorrido em dias
            int tempoDecorrido = 100;

            double pessoasInfectadas = Math.Pow((populacaoInicial * populacaoInicial), (tempoDecorrido/7));
            Console.WriteLine(pessoasInfectadas);
        }


        static void Pi() {

            double raio = 1;

            double pi = 3.1415926535897931;

            double comprimentoCirculo = 2 * pi * raio;

            double areaCirculo = pi * Math.Pow(raio, 2);

            Console.WriteLine("O comprimento do círculo é: " + comprimentoCirculo);
            Console.WriteLine("A área do círuclo é: " + areaCirculo);
        }

        static void Poligonos() {

            int numeroLados = 6;

            var somaAngulos = (numeroLados - 2) * 180;

            var anguloLados = somaAngulos / numeroLados;

            Console.WriteLine("A soma dos angulos internos é de: " 
            + somaAngulos + 
            "° e o polígono é composto por " 
            + numeroLados + 
            " lados de " 
            + anguloLados + 
            "° cada um.");

        }

        static void Delta() {

            double a = 5;
            double b = 5;
            double c = 1;

            var baskara = Math.Pow(b, 2) - 4 * a * c;

            Console.WriteLine("O delta é: " + baskara);

        }

        static void VolumeEsfera() {

            int diametro = 6;
            double pi = 3.1415926535897931; 
            double raio = diametro / 2;

            var volume = (4 / 3) * Math.Pow(raio, 3) * pi;

            Console.WriteLine("O volume da esfera é de " + volume);

        }
    }
}
