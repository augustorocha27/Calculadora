using System;
namespace CheckpointCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Rodando = true;
            while (Rodando)
            {
                Console.Clear();
                Console.WriteLine("CALCULADORA");
                Console.WriteLine();
                Console.WriteLine("ESCOLHA UMA OPÇÃO:");
                Console.WriteLine("1-ADIÇÃO");
                Console.WriteLine("2-SUBTRAÇÃO");
                Console.WriteLine("3-MULTIPLICAÇÃO");
                Console.WriteLine("4-DIVISÃO");
                Console.WriteLine("5-SAIR");
                Console.Write("\nOpção: ");
                string Opcao = Console.ReadLine();
                if (Opcao == "5")
                {
                    Rodando = false;
                    break;
                }
                if (Opcao != "1" && Opcao != "2" && Opcao != "3" && Opcao != "4")
                {
                    Console.WriteLine("Essa opção não existe, escolha um número válido !");
                    Console.ReadKey();
                    continue;
                }
                Console.Write("Digite o primeiro número: ");
                double NumeroUm = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                double NumeroDois = double.Parse(Console.ReadLine());
                double Resultado = 0;
                switch (Opcao)
                {
                    case "1":
                        Resultado = NumeroUm + NumeroDois;
                        Console.WriteLine($"\nResultado: {NumeroUm} + {NumeroDois} = {Resultado}");
                        break;
                    case "2":
                        Resultado = NumeroUm - NumeroDois;
                        Console.WriteLine($"\nResultado: {NumeroUm} - {NumeroDois} = {Resultado}");
                        break;
                    case "3":
                        Resultado = NumeroUm * NumeroDois;
                        Console.WriteLine($"\nResultado: {NumeroUm} * {NumeroDois} = {Resultado}");
                        break;
                    case "4":
                        if (NumeroDois == 0)
                        {
                            Console.WriteLine("\nErro: Divisão por zero não é permitida.");
                        }
                        else
                        {
                            Resultado = NumeroUm / NumeroDois;
                            Console.WriteLine($"\nResultado: {NumeroUm} / {NumeroDois} = {Resultado}");
                        }
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}