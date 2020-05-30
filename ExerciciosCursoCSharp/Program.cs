using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int rodadas = 10;
                for (int i = 0; i < rodadas; i++)
                {
                    Console.WriteLine($"RODADA {i} de {rodadas}");
                    Console.WriteLine();


                    exe();


                    Console.WriteLine();
                    Console.WriteLine("------------------------ APERTE ENTER PARA CONTINUAR");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                //Console.ReadLine();
            }
        }

        static void exe()
        {

        }
        static void _81()
        {
            var tmat = Console.ReadLine().Split(' ');
            int ql = int.Parse(tmat[0]);
            int qc = int.Parse(tmat[1]);
            var mat = new int[ql, qc];
            for (int l = 0; l < ql; l++)
            {
                var linha = Console.ReadLine().Split(' ');
                for (int c = 0; c < qc; c++)
                    mat[l, c] = int.Parse(linha[c]);
            }
            int num = int.Parse(Console.ReadLine());
            var valores = new Dictionary<int[], int[]>();
            for (int l = 0; l < ql; l++)
                for (int c = 0; c < qc; c++)
                    if (mat[l, c] == num)
                    {
                        var pos = new int[] { l, c };
                        var vizinhos = new int[4];
                        if (l > 0)
                            vizinhos[0] = mat[l - 1, c];
                        if (l < ql - 1)
                            vizinhos[1] = mat[l + 1, c];
                        if (c > 0)
                            vizinhos[2] = mat[l, c - 1];
                        if (c < qc - 1)
                            vizinhos[3] = mat[l, c + 1];
                        valores.Add(pos, vizinhos);
                    }
            foreach (var item in valores)
            {
                Console.WriteLine($"Position {item.Key[0]}, {item.Key[1]}:");
                int value;
                if ((value = item.Value[2]) > 0)
                    Console.WriteLine($"Left: {value}");
                if ((value = item.Value[3]) > 0)
                    Console.WriteLine($"Right: {value}");
                if ((value = item.Value[0]) > 0)
                    Console.WriteLine($"Up: {value}");
                if ((value = item.Value[1]) > 0)
                    Console.WriteLine($"Down: {value}");
            }
        }
    }
}
