using Aula118.Entities.Enums;
using System.Collections.Generic;

namespace Aula118.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; }

        public Worker()
        {
            Contracts = new List<HourContract>();
        }

        public Worker(string name, double baseSalary, WorkerLevel level, Department department)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            Department = department;
            Contracts = new List<HourContract>();
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            var income = BaseSalary;
            foreach (HourContract contract in Contracts)
                if (contract.Date.Year == year && contract.Date.Month == month)
                    income += contract.TotalValue();
            return income;
        }
    }
}
