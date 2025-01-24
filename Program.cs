using System;

namespace ConversorDeMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorDeMoedas conversor = new ConversorDeMoedas();
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Conversor de Moedas ===");
                Console.WriteLine("1. Converter Moeda");
                Console.WriteLine("2. Sair");
                Console.Write("Escolha uma opção: ");

                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            ConverterMoeda(conversor);
                            break;
                        case 2:
                            Console.WriteLine("Saindo...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                }

                if (opcao != 2)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcao != 2);
        }

        
        // Método para interagir com o usuário e realizar a conversão de moeda.
        
        static void ConverterMoeda(ConversorDeMoedas conversor)
        {
            Console.Clear();
            Console.Write("Digite o valor em BRL (R$): ");
            if (decimal.TryParse(Console.ReadLine(), out decimal valor))
            {
                Console.WriteLine("Escolha a moeda para conversão:");
                Console.WriteLine("1. Dólar (USD)");
                Console.WriteLine("2. Euro (EUR)");
                Console.WriteLine("3. Libra (GBP)");
                Console.Write("Opção: ");

                if (int.TryParse(Console.ReadLine(), out int escolha))
                {
                    string moedaDestino = escolha switch
                    {
                        1 => "USD",
                        2 => "EUR",
                        3 => "GBP",
                        _ => null
                    };

                    if (moedaDestino != null)
                    {
                        decimal resultado = conversor.ConverterPara(valor, moedaDestino);
                        Console.WriteLine($"\n{valor:C} BRL equivale a {resultado:F2} {moedaDestino}");
                    }
                    else
                    {
                        Console.WriteLine("Moeda inválida.");
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }
    }
}