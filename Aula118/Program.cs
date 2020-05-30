using Aula118.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula118
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListaPessoas = new System.Collections.Generic.List<Pessoa>();
            string entrada;
            while (!string.IsNullOrEmpty(entrada = Console.ReadLine()))
            {
                string[] vet;
                if ((vet = entrada.Split(' ')).Length == 3)
                {
                    var p = new Pessoa();
                    p.Nome = vet[0];
                    p.DataNascimento = DateTime.Parse(vet[1]);
                    p.Naturalidade = (Cidades)Enum.Parse(typeof(Cidades), vet[2]);
                    ListaPessoas.Add(p);
                }
                else
                    Console.WriteLine("seu jumento 1");
            }
            string nomeBuscado;
            while (!string.IsNullOrEmpty(nomeBuscado = PerguntarNome()))
            {
                if (ListaPessoas.Exists(t => t.Nome == nomeBuscado))
                {
                    var p = ListaPessoas.Find(t => t.Nome == nomeBuscado);
                    var texto = new StringBuilder();
                    texto.AppendLine($"Nome: {p.Nome}");
                    texto.AppendLine($"Idade: {p.Idade}");
                    texto.AppendLine($"Naturalidade: {p.Naturalidade.ToString()}");
                    texto.AppendLine();
                    Console.WriteLine(texto.ToString());
                }
                else
                    Console.WriteLine("seu jumento 2!!!!!!!");
            }

            var mae = new Pessoa()
            {
                Nome = "Maria",
                DataNascimento = DateTime.Parse("02/10/1955"),
                Naturalidade = (Cidades)Enum.Parse(typeof(Cidades), "Rubiataba"),
                Mae = null
            };

            var pjader = ListaPessoas.Find(t => t.Nome == mae.Nome);
            pjader.Mae = mae;

            Console.WriteLine(pjader.Mae.Nome);
            Console.ReadLine();
        }

        static string PerguntarNome()
        {
            string pergunta = "Digite o nome da pessoa desejada (em branco finaliza):";
            Console.WriteLine(pergunta);
            return Console.ReadLine();
        }
    }
}
