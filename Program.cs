using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeColecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string[] cidades = new string[] { "Brasília", "São Paulo", "Rio de Janeiro", "Recife" };

            //var cidades = new List<string>
            //{
            //    "Brasília",
            //    "São Paulo",
            //    "Rio de Janeiro",
            //    "Recife"
            //};

            //cidades.Add("Curitiba");
            //cidades.Add("Campo Grande");

            //var filtro = from c in cidades
            ////             where c.StartsWith("R")
            ////             select c;

            ////expressão Lâmbida:
            //var filtro = cidades.Where(x => x.Equals("Recife"));

            var c = new Dictionary<string, List<string>>();

            c.Add("RN", new List<string> { "Natal", "Mossoró", "Parnamirim" });
            c.Add("RJ", new List<string> { "Rio de Janeiro", "Campo Grande" });


            var cidades = c["RN"];     

            foreach (var cidade in cidades)
            {
                Console.WriteLine(cidade);
            }
            Console.ReadKey();
        }
    }
}
