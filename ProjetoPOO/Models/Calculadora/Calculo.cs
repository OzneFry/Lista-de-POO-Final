using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPOO.Models.Calculadora
{
    public class Calculo
    {
        public double ValorA { get; set; }
        public double ValorB { get; set; }
        private double Resultado { get; set; }

        public void CalcularSoma()
        {
            Resultado = ValorA + ValorB;
        }

        public void CalcularSubtracao()
        {
            Resultado = ValorA - ValorB;
        }

        public void CalcularMultiplicacao()
        {
            Resultado = ValorA * ValorB;
        }

        public double RetornarMaior()
        {
            return Math.Max(ValorA, ValorB);
        }

        public double SomarGeral(double valor)
        {
            return ValorA + ValorB + valor;
        }

        public void ImprimirResultado()
        {
            Console.WriteLine($"Resultado: {Resultado}");
        }
    }
}