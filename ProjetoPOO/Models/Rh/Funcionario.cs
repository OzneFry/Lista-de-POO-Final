using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPOO.Rh
{
    public class Funcionario
    {
        public string NomeCompleto { get; set; }
        public double Salario { get; set; }

        public virtual void ExibirDados()
        {
            string[] partesNome = NomeCompleto.Split(' ');
            string sobrenome = partesNome[partesNome.Length - 1].ToUpper();

            Console.WriteLine($"Sobrenome: {sobrenome}");
            Console.WriteLine($"Salário: {Salario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");
        }
    }
}