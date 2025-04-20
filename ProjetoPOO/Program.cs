using ProjetoPOO.Models;
using ProjetoPOO.Models.Calculadora;
using ProjetoPOO.Models.Estacionamento;
using ProjetoPOO.Models.Rh;
using ProjetoPOO.Rh;

namespace ProjetoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione o exercício:");
            Console.WriteLine("1 - Produto/Estoque");
            Console.WriteLine("2 - Calculadora");
            Console.WriteLine("3 - Sistema RH");
            Console.WriteLine("4 - Estacionamento");
            Console.Write("Opção: ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    ExecutarExercicioProduto();
                    break;
                case 2:
                    ExecutarExercicioCalculadora();
                    break;
                case 3:
                    ExecutarExercicioRh();
                    break;
                case 4:
                    ExecutarExercicioEstacionamento();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        static void ExecutarExercicioProduto()
        {
            var produto = new Produto
            {
                Nome = "Notebook",
                Preco = 3500.00,
                Quantidade = 10
            };

            produto.AdicionarEstoque();

            Console.WriteLine($"Produto: {produto.Nome}");
            Console.WriteLine($"Quantidade em estoque: {produto.QuantidadeTotal}");
            Console.WriteLine($"Valor total em estoque: {produto.ValorTotalEmEstoque():C}");

            Console.Write("\nDigite a quantidade para remover: ");
            int qtdeRemover = Convert.ToInt32(Console.ReadLine());

            try
            {
                produto.RemoverEstoque(qtdeRemover);
                Console.WriteLine($"Estoque atualizado: {produto.QuantidadeTotal}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        static void ExecutarExercicioCalculadora()
        {
            var calculadora = new Calculadora();
            calculadora.ExecutarCalculadora();
        }

        static void ExecutarExercicioRh()
        {
            var funcionario = new Funcionario
            {
                NomeCompleto = "João da Silva",
                Salario = 4500.00
            };

            Console.WriteLine("\nDados do Funcionário:");
            funcionario.ExibirDados();

            var gerente = new Gerente
            {
                NomeCompleto = "Maria Oliveira",
                Salario = 15000.00,
                Departamento = "TI"
            };

            Console.WriteLine("\nDados do Gerente:");
            gerente.ExibirDados();
        }

        static void ExecutarExercicioEstacionamento()
        {
            var vaga = new VagaEstacionamento(101, "Carro");

            Console.WriteLine("\nInformações iniciais:");
            vaga.ExibirInformacoes();

            Console.WriteLine("\nOcupando a vaga...");
            vaga.OcuparVaga();
            vaga.ExibirInformacoes();

            Console.WriteLine("\nTentando alterar tipo para Moto...");
            vaga.AlterarTipoVeiculo("Moto");

            Console.WriteLine("\nLiberando a vaga...");
            vaga.LiberarVaga();

            Console.WriteLine("\nAlterando tipo para Moto...");
            vaga.AlterarTipoVeiculo("Moto");
            vaga.ExibirInformacoes();
        }
    }
}