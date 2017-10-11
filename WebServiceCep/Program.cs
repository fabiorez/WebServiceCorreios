using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceCep
{
    using CEPService;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o CEP que deseja pesquisar: ");
            var cep = Console.ReadLine();

            if(!string.IsNullOrEmpty(cep))
            {
                ConsultaCEP(cep);
            }
        }

        private static void ConsultaCEP(string cep)
        {
            using (var ws = new AtendeClienteClient())
            {
                var resposta = ws.consultaCEP(cep);

                Console.Clear();
                Console.WriteLine(string.Format("Endereço: {0}", resposta.end));
                Console.WriteLine(string.Format("Bairro: {0}", resposta.bairro));
                Console.WriteLine(string.Format("Cidade: {0}", resposta.cidade));
                Console.WriteLine(string.Format("Cep: {0}", resposta.uf));
                Console.WriteLine(string.Format("Estado: {0}", resposta.cep));
                Console.WriteLine("");
                Console.WriteLine("PRESSIONE QUALUQUER TECLA");

                Console.ReadKey();
            }
        }
    }
}
