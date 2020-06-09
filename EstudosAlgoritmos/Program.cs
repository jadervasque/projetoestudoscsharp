using System;

namespace EstudosAlgoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int rodadas = 3;
                for (int i = 0; i < rodadas; i++)
                {
                    Console.WriteLine($"RODADA {i} de {rodadas}");
                    Console.WriteLine();


                    atual();


                    Console.WriteLine();
                    Console.WriteLine("------------------------ APERTE ENTER PARA CONTINUAR");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        static void atual()
        {

        }

        static void InsertionSortDecreasing()
        {
            //Insertion-Sort

            //cria um vetor A de tamanho aleatório n
            var rdn = new Random();
            int n = rdn.Next(5, 15);
            int[] A = new int[n];

            //preenche o vetor A aleatoriamente
            for (int i = 0; i < A.Length; i++)
                A[i] = rdn.Next(1, 50);

            ImprimeVetor(A);

            //reordenação Insertion Sort descrescente

            for (int j = A.Length - 2; j >= 0; j--)
            {
                //faz backup do valor atual j
                int chave = A[j];

                //seta i como a posição imediatamente posterior para comparação com j
                int i = j + 1;

                //testa se existe posição posterior a i no vetor
                //e se o valor anterior é menor que a posição atual i
                while (i < A.Length && A[i] > chave)
                {
                    //seta a posição anterior a i como a posição de i
                    //ou seja, passa para frente
                    A[i - 1] = A[i];
                    i++;
                }

                A[i - 1] = chave;
            }
            ImprimeVetor(A);

        }

        static void InsertionSortIncreasing()
        {
            //cria um vetor A de tamanho aleatório n
            var rdn = new Random();
            int n = rdn.Next(5, 15);
            int[] A = new int[n];

            //reordenação o vetor A aleatoriamente
            for (int i = 0; i < A.Length; i++)
                A[i] = rdn.Next(1, 50);

            ImprimeVetor(A);

            //rdenação Insertion Sort
            //começa a ordenação a partir da segunda posição do vetor
            for (int j = 1; j < A.Length; j++)
            {
                //faz backup do valor atual de j
                int chave = A[j];

                //seta i como a posição imediatamente anterior para comparação com j
                int i = j - 1;

                //testa se existe posição anterior a i no vetor
                //e se o valor anterior é maior que a posição atual i
                while (i > -1 && A[i] > chave)
                {
                    //seta a posição posterior a i como a posição de i
                    //ou seja, passa para frente
                    A[i + 1] = A[i];

                    //desce i uma posição
                    i--;
                }

                //seta a posição posterior a i como o backup de j, ou seja, chave
                A[i + 1] = chave;
            }
            ImprimeVetor(A);

        }

        static void ImprimeVetor(int[] array, string nome = "A")
        {
            Console.Write($"{nome} = ");
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]}, ");
            Console.WriteLine();
        }
    }
}
