namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal PrecoInicial = 0;
        private decimal PrecoPorHora = 0;
        private List<string> VeiculosEstacionados = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.PrecoInicial = precoInicial;
            this.PrecoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaVeiculo = Console.ReadLine();
            VeiculosEstacionados.Add(placaVeiculo);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            if (VeiculosEstacionados.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = PrecoInicial + PrecoPorHora * horas;

                VeiculosEstacionados.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (VeiculosEstacionados.Any())
            {
                Console.WriteLine("Os veículos estacionados são:\n");

                VeiculosEstacionados.ForEach(veiculo =>
                {
                    Console.WriteLine($"{veiculo.ToUpper()}\n");
                });
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
