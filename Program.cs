// See https://aka.ms/new-console-template for more information
using DoacaoRacao;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Doação de Ração para Cachorros ===");

        // Criando objeto da classe Doacao
        Doacao novaDoacao = new Doacao();

        // Coletando dados do usuário
        Console.Write("Digite seu nome: ");
        novaDoacao.NomeDoador = Console.ReadLine();

        Console.Write("Digite a quantidade de ração em kg: ");
        double quantidade;
        while (!double.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0)
        {
            Console.Write("Quantidade inválida. Digite novamente: ");
        }
        novaDoacao.QuantidadeKg = quantidade;

        Console.Write("Digite o local de doação (bairro ou ONG): ");
        novaDoacao.Local = Console.ReadLine();

        // Mostrando resultado
        novaDoacao.RegistrarDoacao();

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
