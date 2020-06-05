using System;
using Aula118.Entities;
using Aula118.Views;

namespace Aula118
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var worker = new Worker();
                worker.Department = Messages.EnterDepartmentName();
                Messages.EnterWorkerData(ref worker);
                worker.Contracts = Messages.EnterContracts(Messages.EnterNumberContracts());
                Console.WriteLine();
                Messages.PrintIncome(worker);
            } while (Messages.RepeatOperation());
        }
    }
}
