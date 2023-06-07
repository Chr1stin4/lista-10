using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;



            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Exercício 1");
                Console.WriteLine("2. Exercício 2");
                Console.WriteLine("3. Exercício 3");
                Console.WriteLine("4. Exercício 4");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());



                switch (opcao)
                {
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }



                Console.WriteLine();
            } while (opcao != 4);
        }



        static void Exercicio1()
        {
            // Código do exercício 1
            //  Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vetor = GerarVetor(tamanho);
            double media = CalcularMedia(vetor);

            Console.WriteLine("Vetor gerado: " + string.Join(", ", vetor));
            Console.WriteLine("Média aritmética: " + media);
        }

        static int[] GerarVetor(int tamanho)
        {
            int[] vetor = new int[tamanho];
            Random random = new Random();

            for (int i = 0; i < tamanho; i++)
            {
                int valor = random.Next(1, 101); // Intervalo de 1 a 100, você pode ajustar conforme necessário
                vetor[i] = valor;
            }

            return vetor;
        }

        static double CalcularMedia(int[] vetor)
        {
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }

            double media = (double)soma / vetor.Length;
            return media;



            Console.WriteLine("Executando o exercício 1...");
        }



        static void Exercicio2()
        {
            // Código do exercício 2
            // Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vetor = GerarVetor(tamanho);
            double media = CalcularMedia(vetor);
            int somaPares = CalcularSomaPares(vetor);
            int somaImpares = CalcularSomaImpares(vetor);

            Console.WriteLine("Vetor gerado: " + string.Join(", ", vetor));
            Console.WriteLine("Média aritmética: " + media);
            Console.WriteLine("Soma dos valores pares: " + somaPares);
            Console.WriteLine("Soma dos valores ímpares: " + somaImpares);
        }

        static int[] GerarVetor(int tamanho)
        {
            int[] vetor = new int[tamanho];
            Random random = new Random();

            for (int i = 0; i < tamanho; i++)
            {
                int valor = random.Next(1, 101); // Intervalo de 1 a 100, você pode ajustar conforme necessário
                vetor[i] = valor;
            }

            return vetor;
        }

        static double CalcularMedia(int[] vetor)
        {
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }

            double media = (double)soma / vetor.Length;
            return media;
        }

        static int CalcularSomaPares(int[] vetor)
        {
            int somaPares = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    somaPares += vetor[i];
                }
            }

            return somaPares;
        }

        static int CalcularSomaImpares(int[] vetor)
        {
            int somaImpares = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    somaImpares += vetor[i];
                }
            }

            return somaImpares;



            Console.WriteLine("Executando o exercício 2...");
        }



        static void Exercicio3()
        {
            // Código do exercício 3
            //  Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vetor = GerarVetor(tamanho);

            Console.WriteLine("Vetor de dados (ordem direta):");
            MostrarVetor(vetor);

            Console.WriteLine("\nVetor de dados (ordem inversa):");
            MostrarVetorInverso(vetor);
        }

        static int[] GerarVetor(int tamanho)
        {
            int[] vetor = new int[tamanho];
            Random random = new Random();

            for (int i = 0; i < tamanho; i++)
            {
                int valor = random.Next(1, 101); // Intervalo de 1 a 100, você pode ajustar conforme necessário
                vetor[i] = valor;
            }

            return vetor;
        }

        static void MostrarVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }
        }

        static void MostrarVetorInverso(int[] vetor)
        {
            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                Console.Write(vetor[i] + " ");



                Console.WriteLine("Executando o exercício 3...");
        }
    }
    static void Exercicio4()
    {
            // Código do exercício 4
            //  Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vetor = GerarVetor(tamanho);
            MostrarVetor(vetor);

            double media = CalcularMediaDivisiveis(vetor);
            Console.WriteLine("\nMédia aritmética dos valores divisíveis por 3 e por 5: " + media);
        }

        static int[] GerarVetor(int tamanho)
        {
            int[] vetor = new int[tamanho];
            Random random = new Random();

            for (int i = 0; i < tamanho; i++)
            {
                int valor = random.Next(1, 101); // Intervalo de 1 a 100, você pode ajustar conforme necessário
                vetor[i] = valor;
            }

            return vetor;
        }

        static void MostrarVetor(int[] vetor)
        {
            Console.WriteLine("Valores do vetor:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }
        }

        static double CalcularMediaDivisiveis(int[] vetor)
        {
            int soma = 0;
            int quantidade = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 3 == 0 && vetor[i] % 5 == 0)
                {
                    soma += vetor[i];
                    quantidade++;
                }
            }

            if (quantidade == 0)
            {
                return 0; // Evita a divisão por zero se não houver números divisíveis por 3 e por 5
            }

            double media = (double)soma / quantidade;
            return media;



            Console.WriteLine("Executando o exercício 4...");
    }
}


