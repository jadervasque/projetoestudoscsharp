using System;

namespace Aula71
{
    static class Program
    {
        static void Main2(string[] args)
        {
            Console.Write("How many rooms will be rented? ");

            int qrooms = 10;
            int n = int.Parse(Console.ReadLine());

            Rent[] vect = new Rent[qrooms];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Rent #" + (i + 1) + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room - 1] = new Rent { Name = name, Email = email, Room = room };
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < qrooms; i++)
            {
                if (vect[i] != null)
                {
                    Console.Write((i + 1) + ": ");
                    Console.Write(vect[i].Name + ", ");
                    Console.WriteLine(vect[i].Email);
                }
            }

        }
    }

    // Criar uma nova classe e inserir esse código dentro
    class Rent
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }
    }
}
