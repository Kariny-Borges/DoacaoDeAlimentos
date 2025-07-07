using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoacaoRacao
{
    //  Doação
    public class Doacao
    {
        public string NomeDoador { get; set; }
        public double QuantidadeKg { get; set; }
        public string Local { get; set; }

        public void RegistrarDoacao()
        {
            Console.WriteLine("\nDoação registrada com sucesso!");
            Console.WriteLine($"Obrigado, {NomeDoador}!");
            Console.WriteLine($"Você doou {QuantidadeKg} kg de ração.");
            Console.WriteLine($"O alimento será destinado ao local: {Local}");
            Console.WriteLine("Os cães agradecem sua ajuda para continuarem alimentados!\n");
        }
    }
}
