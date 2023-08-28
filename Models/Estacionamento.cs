namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
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
            string placa = "";
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            string placa = "";
            Console.WriteLine("Digite a placa do veículo para remover: ");
            Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = 0;
                decimal valorTotal = 0; 

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                Console.ReadLine();
                
                valorTotal = precoInicial + precoPorHora * horas;

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                int contForEach = 0;
                foreach(string item in veiculos)
                {
                    Console.WriteLine($"Os veículos estacionados são: {item}");
                    contForEach++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
