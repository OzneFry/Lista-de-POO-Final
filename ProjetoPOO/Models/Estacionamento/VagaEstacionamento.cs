using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPOO.Models.Estacionamento
{
    public class VagaEstacionamento
    {
        public int NumeroVaga { get; }
        public bool Ocupada { get; private set; }

        private string _tipoVeiculo;
        public string TipoVeiculo
        {
            get => _tipoVeiculo;
            private set
            {
                if (value != "Carro" && value != "Moto" && value != "Caminhão")
                    throw new ArgumentException("Tipo de veículo inválido");

                _tipoVeiculo = value;
            }
        }

        public VagaEstacionamento(int numeroVaga, string tipoVeiculo)
        {
            NumeroVaga = numeroVaga;
            TipoVeiculo = tipoVeiculo;
            Ocupada = false;
        }

        public void OcuparVaga()
        {
            Ocupada = true;
        }

        public void LiberarVaga()
        {
            Ocupada = false;
        }

        public void AlterarTipoVeiculo(string novoTipo)
        {
            if (Ocupada)
            {
                Console.WriteLine("Não é possível alterar o tipo de veículo com a vaga ocupada");
                return;
            }

            TipoVeiculo = novoTipo;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Vaga {NumeroVaga}");
            Console.WriteLine($"Tipo: {TipoVeiculo}");
            Console.WriteLine($"Status: {(Ocupada ? "Ocupada" : "Livre")}");
        }
    }
}