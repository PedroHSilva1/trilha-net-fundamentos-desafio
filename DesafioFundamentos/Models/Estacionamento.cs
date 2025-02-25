namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        string placa = "";
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Clear();
           
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine();
            
            veiculos.Add(placa);
            Console.WriteLine($"O veículo {placa} foi estacionado com sucesso.");
        }

        public void RemoverVeiculo()
        {   
            Console.Clear();
            Console.WriteLine("Digite a placa do veículo para remover:");

            placa = "";
            placa = Console.ReadLine();

            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = 0;
                decimal valorTotal = 0; 
                int.TryParse(Console.ReadLine(), out horas);
                valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            Console.Clear();
            
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
