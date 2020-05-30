using Aula118.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula118.Entities
{
    class Worker
    {
        private string name;
        private double baseSalary;
        private WorkerLevel level;

        public string Name { get => name; set => name = value; }
        public double BaseSalary { get => baseSalary; set => baseSalary = value; }
        internal WorkerLevel Level { get => level; set => level = value; }
    }
}
