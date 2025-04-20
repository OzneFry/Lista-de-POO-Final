using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPOO.Models.Calculadora
{
    public class Calculadora
    {
        private readonly Calculo _calculo = new Calculo();

        public void LerValores()
        {
            Console.Write("Digite o primeiro valor: ");
            _calculo.ValorA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            _calculo.ValorB = Convert.ToDouble(Console.ReadLine());
        }

        public void ExecutarCalculadora()
        {
            LerValores();

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nMenu Calculadora:");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Maior valor");
                Console.WriteLine("5 - Somar com outro valor");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        _calculo.CalcularSoma();
                        _calculo.ImprimirResultado();
                        break;
                    case 2:
                        _calculo.CalcularSubtracao();
                        _calculo.ImprimirResultado();
                        break;
                    case 3:
                        _calculo.CalcularMultiplicacao();
                        _calculo.ImprimirResultado();
                        break;
                    case 4:
                        Console.WriteLine($"Maior valor: {_calculo.RetornarMaior()}");
                        break;
                    case 5:
                        Console.Write("Digite outro valor para somar: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {_calculo.SomarGeral(valor)}");
                        break;
                    case 0:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}