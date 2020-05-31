using System;
using System.Collections.Generic;
using System.Text;
using Aula118.Entities;
using Aula118.Entities.Enums;

namespace Aula118.Views
{
    static class Messages
    {
        public static Department EnterDepartmentName()
        {
            Console.Write("Enter department's name: ");
            return new Department(Console.ReadLine());
        }

        public static void EnterWorkerData(ref Worker worker)
        {
            Console.WriteLine("Enter worker data:");
            worker.Name = EnterWorkerName();
            worker.Level = EnterWorkerLevel();
            worker.BaseSalary = EnterWorkerBaseSalary();
        }

        public static string EnterWorkerName()
        {
            Console.Write("Name: ");
            return Console.ReadLine();
        }

        public static WorkerLevel EnterWorkerLevel()
        {
            Console.Write("Level (Junior/Midlevel/Senior): ");
            WorkerLevel ret = new WorkerLevel();
            Enum.TryParse<WorkerLevel>(Console.ReadLine(), out ret);
            return ret;
        }

        public static double EnterWorkerBaseSalary()
        {
            Console.Write("Base salary: ");
            return double.Parse(Console.ReadLine());

        }

        public static int EnterNumberContracts()
        {
            Console.Write("How many contracts to this worker? ");
            return int.Parse(Console.ReadLine());
        }

        public static List<HourContract> EnterContracts(int numberContracts)
        {
            var contracts = new List<HourContract>();
            for (int i = 1; i <= numberContracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                var contract = new HourContract();
                Console.Write("Date (DD/MM/YYYY): ");
                contract.Date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                contract.ValuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                contract.Hours = int.Parse(Console.ReadLine());
                contracts.Add(contract);
            }
            return contracts;
        }

        public static DateTime? EnterMonthYear()
        {
            try
            {
                Console.Write("Enter month and year to calculate income (MM/YYYY): ");
                string[] monthYear = Console.ReadLine().Split('/');
                return new DateTime(int.Parse(monthYear[1]), int.Parse(monthYear[0]), 1);
            }
            catch
            {
                return null;
            }
        }

        public static void PrintIncome(Worker worker)
        {
            DateTime? monthYear;
            while ((monthYear = EnterMonthYear()).HasValue)
            {
                Console.WriteLine($"Name: {worker.Name}");
                Console.WriteLine($"Department: {worker.Department.Name}");
                int month = ((DateTime)monthYear).Month;
                int year = ((DateTime)monthYear).Year;
                StringBuilder str = new StringBuilder();
                str.Append("Income for ");
                str.Append(month.ToString("00"));
                str.Append("/");
                str.Append(year.ToString("0000"));
                str.Append(": ");
                str.AppendLine(worker.Income(year, month).ToString("F2"));
                Console.WriteLine(str.ToString());
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static bool RepeatOperation()
        {
            Console.Write("Deseja realizar a operação novamente? (S/N): ");
            string yesOrNo;
            yesOrNo = Console.ReadLine().ToUpper();
            if (yesOrNo == "S") return true;
            else return false;
        }
    }
}
