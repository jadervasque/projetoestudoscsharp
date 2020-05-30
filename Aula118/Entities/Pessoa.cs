using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula118.Entities
{
    enum Cidades : int
    {
        Araguaina,
        Palmas,
        Gurupi,
        Rubiataba
    }

    class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Cidades Naturalidade { get; set; }
        public int Idade
        {
            get
            {
                int anoAtual = DateTime.Now.Year;
                int anoNascimento = DataNascimento.Year;
                return anoAtual - anoNascimento;
            }
        }
        public Pessoa Mae { get; set; }

        public Pessoa()
        {

        }

        public override string ToString()
        {
            return $"{Nome}, {DataNascimento.ToShortDateString()}, {Naturalidade.ToString()}";
        }
    }
}
