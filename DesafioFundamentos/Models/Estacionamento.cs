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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // IMPLEMENTADO
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            
            string placa = Console.ReadLine();

         // Verifica se a placa não está vazia
         if (!string.IsNullOrWhiteSpace(placa))
             {  veiculos.Add(placa);
              Console.WriteLine($"Veículo com placa {placa} adicionado com sucesso!");
             }
         else
            {
                 Console.WriteLine("Placa inválida. Tente novamente.");
            }
      }

     public void RemoverVeiculo()
{
    Console.WriteLine("Digite a placa do veículo para remover:");
    string placa = Console.ReadLine();

    // Verifica se o veículo existe na lista (ignorando maiúsculas/minúsculas)
    if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
    {
        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
        
        // Validação segura para horas
        if (int.TryParse(Console.ReadLine(), out int horas))
        {
            // Calcula valor total
            decimal valorTotal = precoInicial + precoPorHora * horas;

            // Remove placa da lista, ignorando maiúsculas/minúsculas
            veiculos.RemoveAll(x => x.Equals(placa, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }
        else
        {
            Console.WriteLine("Quantidade de horas inválida. Operação cancelada.");
        }
    }
    else
    {
        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
    }
}

        public void ListarVeiculos()
{
    // Verifica se há veículos no estacionamento
    if (veiculos.Any())
    {
        Console.WriteLine("Os veículos estacionados são:");
        
        // Laço de repetição que percorre e exibe cada veículo
        foreach (string veiculo in veiculos)
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
