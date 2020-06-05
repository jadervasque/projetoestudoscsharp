using System;

namespace ExerciciosURI
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


                    uri();


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

        static void uri()
        {

        }
        #region Resolvidos
        static void _1024()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                System.Text.StringBuilder message = new System.Text.StringBuilder(Console.ReadLine());
                //Somente caracteres que sejam letras minúsculas e maiúsculas devem ser deslocadas 3 posições para a direita
                for (int j = 0; j < message.Length; j++)
                {
                    byte jb = (byte)message[j];
                    if (jb >= 65 && jb <= 90 || jb >= 97 && jb <= 122)
                    {
                        message[j] = (char)(jb + 3);
                    }
                }
                //A linha deverá ser invertida
                string msg = string.Empty;
                for (int j = message.Length - 1; j >= 0; j--)
                {
                    msg += message[j];
                }
                message = new System.Text.StringBuilder(msg);
                //Todo e qualquer caractere a partir da metade em diante (truncada) devem ser deslocados uma posição para a esquerda na tabela ASCII
                for (int j = (int)(Math.Truncate((decimal)message.Length) / 2); j < message.Length; j++)
                {
                    byte jb = (byte)message[j];
                    message[j] = (char)(jb - 1);
                }
                Console.WriteLine(message.ToString());
            }
            Console.ReadKey();
        }
        static void _1022()
        {
            int n = int.Parse(Console.ReadLine());
            string[] casos = new string[n];
            for (int i = 0; i < n; i++)
                casos[i] = Console.ReadLine();
            foreach (var teste in casos)
            {
                int n1 = int.Parse(teste.Split(' ')[0]);
                int d1 = int.Parse(teste.Split(' ')[2]);
                int n2 = int.Parse(teste.Split(' ')[4]);
                int d2 = int.Parse(teste.Split(' ')[6]);
                int n3 = 0;
                int d3 = 0;
                switch (teste.Split(' ')[3])
                {
                    case "+":
                        n3 = n1 * d2 + n2 * d1;
                        d3 = d1 * d2;
                        break;
                    case "-":
                        n3 = n1 * d2 - n2 * d1;
                        d3 = d1 * d2;
                        break;
                    case "*":
                        n3 = n1 * n2;
                        d3 = d1 * d2;
                        break;
                    case "/":
                        n3 = n1 * d2;
                        d3 = n2 * d1;
                        break;
                }
                int maxdiv = Math.Abs(n3 < d3 ? n3 : d3);
                int mmc = 1;
                for (int i = 2; i <= maxdiv; i++)
                {
                    if (n3 % i == 0 && d3 % i == 0)
                        mmc = i;
                }
                int n4 = n3 / mmc;
                int d4 = d3 / mmc;
                Console.WriteLine($"{n3}/{d3} = {n4}/{d4}");
            }
        }
        static void _1564()
        {
            var rodadas = new System.Collections.Generic.List<int>();
            string entrada;
            while (!string.IsNullOrEmpty(entrada = Console.ReadLine()))
                rodadas.Add(int.Parse(entrada));
            foreach (var caso in rodadas)
                if (caso > 0) Console.WriteLine("vai ter duas!");
                else Console.WriteLine("vai ter copa!");
        }
        static void _1557()
        {
            var qmatrizes = new System.Collections.Generic.List<int>();
            var matrizes = new System.Collections.Generic.List<int[][]>();
            int num;
            while ((num = int.Parse(Console.ReadLine())) != 0)
                qmatrizes.Add(num);
            foreach (var tm in qmatrizes)
            {
                var matriz = new int[tm][];
                var vl = 1;
                for (int l = 0; l < tm; l++)
                {
                    var vc = vl;
                    matriz[l] = new int[tm];
                    for (int c = 0; c < tm; c++)
                    {
                        matriz[l][c] = vc;
                        vc *= 2;
                    }
                    vl *= 2;
                }
                matrizes.Add(matriz);
            }
            foreach (var matriz in matrizes)
            {
                int tm = matriz.Length;
                for (int l = 0; l < tm; l++)
                {
                    string textoLinha = string.Empty;
                    for (int c = 0; c < tm; c++)
                    {
                        string textoCelula = matriz[l][c].ToString();
                        for (int i = textoCelula.Length; i < matriz[matriz.Length - 1][matriz.Length - 1].ToString().Length; i++)
                            textoCelula = $" {textoCelula}";
                        if (c > 0)
                            textoCelula = $" {textoCelula}";
                        textoLinha += textoCelula;
                    }
                    Console.WriteLine(textoLinha);
                }
                Console.WriteLine();
            }
        }
        static void _1541()
        {
            var rodadas = new System.Collections.Generic.List<string>();
            var entrada = string.Empty;
            while ((entrada = Console.ReadLine()) != "0" && !string.IsNullOrEmpty(entrada))
                rodadas.Add(entrada);
            foreach (var caso in rodadas)
            {
                var lcasa = double.Parse(caso.Split(' ')[0]);
                var ccasa = double.Parse(caso.Split(' ')[1]);
                var percentual = double.Parse(caso.Split(' ')[2]) / 100;
                var largura = Math.Floor(Math.Sqrt((lcasa * ccasa) / percentual));
                Console.WriteLine(largura);
            }
        }
        static void _1534()
        {
            var qmatrizes = new System.Collections.Generic.List<int>();
            var matrizes = new System.Collections.Generic.List<int[][]>();
            string tx;
            while (!string.IsNullOrEmpty((tx = Console.ReadLine())))
                qmatrizes.Add(int.Parse(tx));
            foreach (var tm in qmatrizes)
            {
                var matriz = new int[tm][];
                int diagonal1 = 0;
                int diagonal2 = tm;
                for (int l = 0; l < tm; l++)
                {
                    diagonal1 = l;
                    --diagonal2;
                    matriz[l] = new int[tm];
                    for (int c = 0; c < tm; c++)
                    {
                        bool flag1 = c > diagonal1 && c < diagonal2;
                        bool flag2 = c < diagonal1 && c > diagonal2;
                        bool flag3 = c < diagonal1 && c < diagonal2;
                        bool flag4 = c > diagonal1 && c > diagonal2;
                        bool flag5 = c == diagonal1;
                        bool flag6 = c == diagonal2;
                        if (flag1 || flag2 || flag3 || flag4)
                            matriz[l][c] = 3;
                        if (flag6)
                            matriz[l][c] = 2;
                        else if (flag5)
                            matriz[l][c] = 1;
                    }
                }
                matrizes.Add(matriz);
            }
            foreach (var matriz in matrizes)
            {
                int tm = matriz.Length;
                for (int l = 0; l < tm; l++)
                {
                    string textoLinha = string.Empty;
                    for (int c = 0; c < tm; c++)
                        textoLinha += matriz[l][c].ToString();
                    Console.WriteLine(textoLinha);
                }
            }
        }
        static void _1478()
        {
            var qmatrizes = new System.Collections.Generic.List<int>();
            var matrizes = new System.Collections.Generic.List<int[][]>();
            int num;
            while ((num = int.Parse(Console.ReadLine())) != 0)
                qmatrizes.Add(num);
            foreach (var tm in qmatrizes)
            {
                var matriz = new int[tm][];
                int diagonal = 0;
                for (int l = 0; l < tm; l++)
                {
                    diagonal = l;
                    matriz[l] = new int[tm];
                    for (int c = 0; c < tm; c++)
                    {
                        if (c >= diagonal)
                            matriz[l][c] = c + 1 - l;
                        else if (c < diagonal)
                            matriz[l][c] = l + 1 - c;
                    }
                }
                matrizes.Add(matriz);
            }
            foreach (var matriz in matrizes)
            {
                int tm = matriz.Length;
                for (int l = 0; l < tm; l++)
                {
                    string textoLinha = string.Empty;
                    for (int c = 0; c < tm; c++)
                    {
                        string textoCelula = matriz[l][c].ToString();
                        for (int i = textoCelula.Length; i < 3; i++)
                            textoCelula = $" {textoCelula}";
                        if (c > 0)
                            textoCelula = $" {textoCelula}";
                        textoLinha += textoCelula;
                    }
                    Console.WriteLine(textoLinha);
                }
                Console.WriteLine();
            }
        }
        static void _1435()
        {
            var qmatrizes = new System.Collections.Generic.List<int>();
            var matrizes = new System.Collections.Generic.List<int[][]>();
            int num;
            while ((num = int.Parse(Console.ReadLine())) != 0)
                qmatrizes.Add(num);
            foreach (var tm in qmatrizes)
            {
                var matriz = new int[tm][];
                int diagonal1 = 0;
                int diagonal2 = tm;
                for (int l = 0; l < tm; l++)
                {
                    diagonal1 = l;
                    --diagonal2;
                    matriz[l] = new int[tm];
                    for (int c = 0; c < tm; c++)
                    {
                        if (c >= diagonal1 && c <= diagonal2)
                            matriz[l][c] = l + 1;
                        else if (c <= diagonal1 && c >= diagonal2)
                            matriz[l][c] = tm - l;
                        else if (c < diagonal1 && c < diagonal2)
                            matriz[l][c] = c + 1;
                        else if (c > diagonal1 && c > diagonal2)
                            matriz[l][c] = tm - c;
                    }
                }
                matrizes.Add(matriz);
            }
            foreach (var matriz in matrizes)
            {
                int tm = matriz.Length;
                for (int l = 0; l < tm; l++)
                {
                    string textoLinha = string.Empty;
                    for (int c = 0; c < tm; c++)
                    {
                        string textoCelula = matriz[l][c].ToString();
                        for (int i = textoCelula.Length; i < 3; i++)
                            textoCelula = $" {textoCelula}";
                        if (c > 0)
                            textoCelula = $" {textoCelula}";
                        textoLinha += textoCelula;
                    }
                    Console.WriteLine(textoLinha);
                }
                Console.WriteLine();
            }
        }
        static void _1190()
        {
            char operacao = Console.ReadLine().ToCharArray()[0];
            int tm = 12;
            double[][] matriz = new double[tm][];
            double soma = 0;
            int diagonal1 = 0;
            int diagonal2 = 12;
            int count = 0;
            for (int l = 0; l < tm; l++)
            {
                diagonal1 = l;
                --diagonal2;
                matriz[l] = new double[tm];
                for (int c = 0; c < tm; c++)
                {
                    matriz[l][c] = double.Parse(Console.ReadLine());
                    //matriz[l][c] = l * 1.5f + c * 1.5f;
                    if (c > diagonal1 && c > diagonal2)
                    {
                        soma += matriz[l][c];
                        count++;
                    }
                }
            }
            if (operacao == 'S') Console.WriteLine(soma.ToString("F1"));
            else if (operacao == 'M') Console.WriteLine((soma / count).ToString("F1"));
        }
        static void _1189()
        {
            char operacao = Console.ReadLine().ToCharArray()[0];
            int tm = 12;
            double[][] matriz = new double[tm][];
            double soma = 0;
            int diagonal1 = 0;
            int diagonal2 = 12;
            int count = 0;
            for (int l = 0; l < tm; l++)
            {
                diagonal1 = l;
                --diagonal2;
                matriz[l] = new double[tm];
                for (int c = 0; c < tm; c++)
                {
                    matriz[l][c] = double.Parse(Console.ReadLine());
                    //matriz[l][c] = l * 1.5f + c * 1.5f;
                    if (c < diagonal1 && c < diagonal2)
                    {
                        soma += matriz[l][c];
                        count++;
                    }
                }
            }
            if (operacao == 'S') Console.WriteLine(soma.ToString("F1"));
            else if (operacao == 'M') Console.WriteLine((soma / count).ToString("F1"));
        }
        static void _1188()
        {
            char operacao = Console.ReadLine().ToCharArray()[0];
            int tm = 12;
            double[][] matriz = new double[tm][];
            double soma = 0;
            int diagonal1 = 0;
            int diagonal2 = 12;
            int count = 0;
            for (int l = 0; l < tm; l++)
            {
                diagonal1 = l;
                --diagonal2;
                matriz[l] = new double[tm];
                for (int c = 0; c < tm; c++)
                {
                    matriz[l][c] = double.Parse(Console.ReadLine());
                    //matriz[l][c] = l * 1.5f + c * 1.5f;
                    if (c < diagonal1 && c > diagonal2)
                    {
                        soma += matriz[l][c];
                        count++;
                    }
                }
            }
            if (operacao == 'S') Console.WriteLine(soma.ToString("F1"));
            else if (operacao == 'M') Console.WriteLine((soma / count).ToString("F1"));
        }
        static void _1187()
        {
            char operacao = Console.ReadLine().ToCharArray()[0];
            int tm = 12;
            double[][] matriz = new double[tm][];
            double soma = 0;
            int diagonal1 = 0;
            int diagonal2 = 12;
            int count = 0;
            for (int l = 0; l < tm; l++)
            {
                diagonal1 = l;
                --diagonal2;
                matriz[l] = new double[tm];
                for (int c = 0; c < tm; c++)
                {
                    matriz[l][c] = double.Parse(Console.ReadLine());
                    //matriz[l][c] = l * 1.5f + c * 1.5f;
                    if (c > diagonal1 && c < diagonal2)
                    {
                        soma += matriz[l][c];
                        count++;
                    }
                }
            }
            if (operacao == 'S') Console.WriteLine(soma.ToString("F1"));
            else if (operacao == 'M') Console.WriteLine((soma / count).ToString("F1"));
        }
        static void _1186()
        {
            char operacao = Console.ReadLine().ToCharArray()[0];
            int tm = 12;
            float[][] matriz = new float[tm][];
            float soma = 0f;
            int diagonal = 12;
            int count = 0;
            for (int l = 0; l < tm; l++)
            {
                --diagonal;
                matriz[l] = new float[tm];
                for (int c = 0; c < tm; c++)
                {
                    matriz[l][c] = float.Parse(Console.ReadLine());
                    //matriz[l][c] = l * 1.5f + c * 1.5f;
                    if (c > diagonal)
                    {
                        soma += matriz[l][c];
                        count++;
                    }
                }
            }
            if (operacao == 'S') Console.WriteLine(soma.ToString("F1"));
            else if (operacao == 'M') Console.WriteLine((soma / count).ToString("F1"));
        }
        static void _1185()
        {
            char operacao = Console.ReadLine().ToCharArray()[0];
            int tm = 12;
            float[][] matriz = new float[tm][];
            float soma = 0f;
            int diagonal = 12;
            int count = 0;
            for (int l = 0; l < tm; l++)
            {
                --diagonal;
                matriz[l] = new float[tm];
                for (int c = 0; c < tm; c++)
                {
                    matriz[l][c] = float.Parse(Console.ReadLine());
                    //matriz[l][c] = l * 1.5f + c * 1.5f;
                    if (c < diagonal)
                    {
                        soma += matriz[l][c];
                        count++;
                    }
                }
            }
            if (operacao == 'S') Console.WriteLine(soma.ToString("F1"));
            else if (operacao == 'M') Console.WriteLine((soma / count).ToString("F1"));
        }
        static void _1184()
        {
            char operacao = Console.ReadLine().ToCharArray()[0];
            int tm = 12;
            float[][] matriz = new float[tm][];
            float soma = 0f;
            int diagonal;
            int count = 0;
            for (int l = 0; l < tm; l++)
            {
                diagonal = l;
                matriz[l] = new float[tm];
                for (int c = 0; c < tm; c++)
                {
                    matriz[l][c] = float.Parse(Console.ReadLine());
                    //matriz[l][c] = l * 1.5f + c * 1.5f;
                    if (c < diagonal)
                    {
                        soma += matriz[l][c];
                        count++;
                    }
                }
            }
            if (operacao == 'S') Console.WriteLine(soma.ToString("F1"));
            else if (operacao == 'M') Console.WriteLine((soma / count).ToString("F1"));
        }
        static void _1183()
        {
            char operacao = Console.ReadLine().ToCharArray()[0];
            int tm = 12;
            float[][] matriz = new float[tm][];
            float soma = 0f;
            int diagonal;
            int count = 0;
            for (int l = 0; l < tm; l++)
            {
                diagonal = l;
                matriz[l] = new float[tm];
                for (int c = 0; c < tm; c++)
                {
                    matriz[l][c] = float.Parse(Console.ReadLine());
                    //matriz[l][c] = l * 1.5f + c * 1.5f;
                    if (c > diagonal)
                    {
                        soma += matriz[l][c];
                        count++;
                    }
                }
            }
            if (operacao == 'S') Console.WriteLine(soma.ToString("F1"));
            else if (operacao == 'M') Console.WriteLine((soma / count).ToString("F1"));
        }
        static void _1182()
        {
            int coluna = int.Parse(Console.ReadLine());
            char operacao = Console.ReadLine().ToCharArray()[0];
            int tm = 12;
            float[][] matriz = new float[tm][];
            float somaColuna = 0f;
            float mediaColuna = 0f;
            for (int l = 0; l < tm; l++)
            {
                matriz[l] = new float[tm];
                for (int c = 0; c < tm; c++)
                {
                    matriz[l][c] = float.Parse(Console.ReadLine());
                    //matriz[l][c] = i * 1.5f + j * 1.5f;
                    if (c == coluna)
                    {
                        somaColuna += matriz[l][c];
                        mediaColuna += matriz[l][c] / tm;
                    }
                }
            }
            if (operacao == 'S') Console.WriteLine(somaColuna.ToString("F1"));
            else if (operacao == 'M') Console.WriteLine(mediaColuna.ToString("F1"));
        }
        static void _1181()
        {
            int linha = int.Parse(Console.ReadLine());
            char operacao = Console.ReadLine().ToCharArray()[0];
            int tm = 12;
            float[][] matriz = new float[tm][];
            float somaLinha = 0f;
            float mediaLinha = 0f;
            for (int l = 0; l < tm; l++)
            {
                matriz[l] = new float[tm];
                for (int c = 0; c < tm; c++)
                {
                    matriz[l][c] = float.Parse(Console.ReadLine());
                    //matriz[l][c] = i * 1.5f + j * 1.5f;
                    if (l == linha)
                    {
                        somaLinha += matriz[l][c];
                        mediaLinha += matriz[l][c] / tm;
                    }
                }
            }
            if (operacao == 'S') Console.WriteLine(somaLinha.ToString("F1"));
            else if (operacao == 'M') Console.WriteLine(mediaLinha.ToString("F1"));
        }
        static void _1180()
        {
            int n = int.Parse(Console.ReadLine());
            string[] info = Console.ReadLine().Split(' ');
            var vetx = new int[n];
            for (int i = 0; i < n; i++)
                vetx[i] = int.Parse(info[i]);
            int minvalue = vetx[0];
            int posminvalue = 0;
            for (int i = 1; i < n; i++)
                if (vetx[i] < minvalue)
                {
                    minvalue = vetx[i];
                    posminvalue = i;
                }
            Console.WriteLine($"Menor valor: {minvalue}");
            Console.WriteLine($"Posicao: {posminvalue}");
        }
        static void _1179()
        {
            int n = 15;
            //int[] vet = new int[]
            //{
            //    1, 3, 4, -4, 2, 3, 8, 2, 5, -7, 54, 76, 789, 23, 98
            //};
            int[] vet = new int[n];
            for (int i = 0; i < n; i++)
                vet[i] = int.Parse(Console.ReadLine());
            int cpar = 0;
            int cimpar = 0;
            int[] vpar = new int[5];
            int[] vimpar = new int[5];
            for (int i = 0; i < n; i++)
            {
                if (vet[i] % 2 == 0)
                    vpar[cpar++] = vet[i];
                else
                    vimpar[cimpar++] = vet[i];
                if (cimpar == 5 || i + 1 == n)
                {
                    for (int j = 0; j < cimpar; j++)
                        Console.WriteLine(string.Format($"impar[{j}] = {vimpar[j]}"));
                    cimpar = 0;
                }
                if (cpar == 5 || i + 1 == n)
                {
                    for (int j = 0; j < cpar; j++)
                        Console.WriteLine(string.Format($"par[{j}] = {vpar[j]}"));
                    cpar = 0;
                }
            }
        }
        static void _1178()
        {
            int n = 100;
            var vet = new decimal[n];
            vet[0] = decimal.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            for (int i = 1; i < n; i++)
                vet[i] = vet[i - 1] / 2;
            for (int i = 0; i < n; i++)
                Console.WriteLine(string.Format("N[{0}] = {1}", i, Math.Round(vet[i], 4).ToString("F4")));
        }
        static void _1177()
        {
            int n = 1000;
            int t = int.Parse(Console.ReadLine());
            int[] vet = new int[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Format("N[{0}] = {1}", i, count++));
                if (count == t)
                    count = 0;
            }
        }
        static void _1176()
        {
            int casos = int.Parse(Console.ReadLine());
            for (int t = 0; t < casos; t++)
            {
                int n = 61;
                var fibonacci = new ulong[n];
                fibonacci[0] = 0;
                fibonacci[1] = 1;
                for (int f = 2; f < n; f++)
                    fibonacci[f] = fibonacci[f - 1] + fibonacci[f - 2];
                int posicaoDesejada = int.Parse(Console.ReadLine());
                Console.WriteLine(string.Format("Fib({0}) = {1}", posicaoDesejada, fibonacci[posicaoDesejada]));
            }
        }
        static void _1175()
        {
            int n = 20;
            var vet = new double[n];
            for (int i = 0; i < n; i++)
                vet[i] = double.Parse(Console.ReadLine());
            for (int i = 0; i < n / 2; i++)
            {
                int x = n - 1 - i;
                var y = vet[i];
                vet[i] = vet[x];
                vet[x] = y;
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine(string.Format("N[{0}] = {1}", i, vet[i]));
        }
        static void _1174()
        {
            int n = 100;
            var vet = new double[n];
            for (int i = 0; i < n; i++)
                vet[i] = double.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                if (vet[i] <= 10)
                    Console.WriteLine(string.Format("A[{0}] = {1}", i, vet[i].ToString("F1")));
        }
        static void _1164()
        {
            int n = int.Parse(Console.ReadLine());
            for (int t = 0; t < n; t++)
            {
                int soma = 0;
                int num = int.Parse(Console.ReadLine());
                for (int i = 1; i < num; i++)
                    if (num % i == 0)
                        soma += i;
                Console.WriteLine(string.Format("{0}{1} eh perfeito", num, num == soma ? "" : " nao"));
            }
        }
        static void _1157()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    Console.WriteLine(i);
        }
        static void _1156()
        {
            double soma = 0;
            double j = 1.0;
            double i = 1.0;
            while (i <= 39)
            {
                soma += i / j;
                i += 2;
                j *= 2;
            }
            Console.WriteLine(soma.ToString("F2"));
            Console.ReadLine();
        }
        static void _1155()
        {
            double soma = 0;
            for (int i = 1; i <= 100; i++)
                soma += 1.0 / i;
            Console.WriteLine(soma.ToString("F2"));
            Console.ReadLine();
        }
        static void _1153()
        {
            int num = int.Parse(Console.ReadLine());
            int soma = num;
            for (int i = --num; i > 1; i--)
                soma *= i;
            Console.WriteLine(soma);
        }
        static void _1146()
        {
            int entrada = int.Parse(Console.ReadLine());
            while (entrada != 0)
            {
                string texto = string.Empty;
                for (int i = 1; i <= entrada; i++)
                {
                    texto += i;
                    if (i != entrada)
                        texto += " ";
                }
                Console.WriteLine(texto);
                entrada = int.Parse(Console.ReadLine());
            }
        }
        static void _1145()
        {
            string[] info = Console.ReadLine().Split(' ');
            int qtdPorLinha = int.Parse(info[0]);
            int valorMaximo = int.Parse(info[1]);
            int qtdLinhas = (int)Math.Ceiling((double)valorMaximo / qtdPorLinha);
            int count = 0;
            for (int i = 0; i < qtdLinhas; i++)
            {
                string linha = string.Empty;
                for (int t = 1; t <= qtdPorLinha; t++)
                {
                    if (count < valorMaximo)
                    {
                        linha += ++count;
                        if (t != qtdPorLinha)
                            linha += " ";
                    }
                }
                Console.WriteLine(linha);
            }
        }
        static void _1144()
        {
            int qtdRodadas = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdRodadas; i++)
            {
                Console.WriteLine(string.Format("{0} {1} {2}", i, Math.Pow(i, 2), Math.Pow(i, 3)));
                Console.WriteLine(string.Format("{0} {1} {2}", i, Math.Pow(i, 2) + 1, Math.Pow(i, 3) + 1));
            }
        }
        static void _1143()
        {
            int qtdRodadas = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdRodadas; i++)
                Console.WriteLine(string.Format("{0} {1} {2}", i, Math.Pow(i, 2), Math.Pow(i, 3)));
        }
        static void _1142()
        {
            int qtdRodadas = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < qtdRodadas; i++)
            {
                for (int t = 0; t < 3; t++)
                    Console.Write(string.Format("{0} ", ++count));
                Console.WriteLine("PUM");
                count++;
            }
        }
        static void _1133()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                int z = x;
                x = y;
                y = z;
            }
            for (int i = ++x; i < y; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                    Console.WriteLine(i);
            }
        }
        static void _1132()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                int z = x;
                x = y;
                y = z;
            }
            int soma = 0;
            for (int i = x; i <= y; i++)
            {
                if (i % 13 != 0)
                    soma += i;
            }
            Console.WriteLine(soma);
        }
        static void _1113()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            while (a != b)
            {
                if (a > b)
                    Console.WriteLine("Decrescente");
                else
                    Console.WriteLine("Crescente");
                valores = Console.ReadLine().Split(' ');
                a = int.Parse(valores[0]);
                b = int.Parse(valores[1]);
            }
        }
        static void _1159()
        {
            int leitura = int.Parse(Console.ReadLine());
            while (leitura != 0)
            {
                if (leitura % 2 != 0)
                    leitura++;
                int soma = 0;
                for (int i = 0; i < 5; i++)
                {
                    soma += leitura;
                    leitura += 2;
                }
                Console.WriteLine(soma);
                leitura = int.Parse(Console.ReadLine());
            }
        }
        static void _1154()
        {
            double somaIdades = 0;
            int count = 0;
            int idadeAtual = int.Parse(Console.ReadLine());
            while (idadeAtual >= 0)
            {
                somaIdades += idadeAtual;
                idadeAtual = int.Parse(Console.ReadLine());
                count++;
            }
            double media = somaIdades / count;
            Console.WriteLine(media.ToString("F2", System.Globalization.CultureInfo.InvariantCulture));
        }
        static void _1134()
        {
            int[] combustiveis = new int[3] { 0, 0, 0 };
            int combustivelAtual = int.Parse(Console.ReadLine());
            while (combustivelAtual != 4)
            {
                if (combustivelAtual >= 1 && combustivelAtual <= 3)
                    combustiveis[combustivelAtual - 1]++;
                combustivelAtual = int.Parse(Console.ReadLine());
            }
            var texto = new System.Text.StringBuilder();
            texto.AppendLine("MUITO OBRIGADO");
            texto.AppendLine(string.Format("Alcool: {0}", combustiveis[0]));
            texto.AppendLine(string.Format("Gasolina: {0}", combustiveis[1]));
            texto.Append(string.Format("Diesel: {0}", combustiveis[2]));
            Console.WriteLine(texto.ToString());
        }
        static void _1131()
        {
            var grenais = new System.Collections.ArrayList();
            bool novoGrenal = true;
            while (novoGrenal)
            {
                string[] leitura = Console.ReadLine().Split(' ');
                grenais.Add(new int[]
                {
                    int.Parse(leitura[0]),
                    int.Parse(leitura[1])
                });
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine()) == 1 ? true : false;
            }
            int[] estatisticas = new int[3];
            foreach (var partida in grenais)
            {
                int inter = ((int[])partida)[0];
                int gremio = ((int[])partida)[1];
                if (inter == gremio)
                    estatisticas[0]++;
                else if (inter > gremio)
                    estatisticas[1]++;
                else
                    estatisticas[2]++;
            }
            Console.WriteLine("{0} grenais", grenais.Count);
            Console.WriteLine("Inter:{0}", estatisticas[1]);
            Console.WriteLine("Gremio:{0}", estatisticas[2]);
            Console.WriteLine("Empates:{0}", estatisticas[0]);
            if (estatisticas[1] > estatisticas[2])
                Console.WriteLine("Inter venceu mais");
            else if (estatisticas[1] < estatisticas[2])
                Console.WriteLine("Gremio venceu mais");
        }
        static void _1118()
        {
            int testar = 1;
            while (testar == 1)
            {
                int notasValidas = 0;
                double[] intervaloAceito = new double[] { 0, 10 };
                double somaNotasValidas = 0;
                while (notasValidas < 2)
                {
                    double notaAtual = double.Parse(Console.ReadLine());
                    if (notaAtual < intervaloAceito[0] || notaAtual > intervaloAceito[1])
                        Console.WriteLine("nota invalida");
                    else
                    {
                        somaNotasValidas += notaAtual;
                        notasValidas++;
                    }
                }
                double media = (somaNotasValidas / notasValidas);
                Console.WriteLine(string.Format("media = {0}", media.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)));
                int resposta = 0;
                while (resposta == 0)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    testar = int.Parse(Console.ReadLine());
                    if (testar == 1 || testar == 2)
                        resposta++;
                }
            }
        }
        static void _1117()
        {
            int notasValidas = 0;
            double[] intervaloAceito = new double[] { 0, 10 };
            double somaNotasValidas = 0;
            while (notasValidas < 2)
            {
                double notaAtual = double.Parse(Console.ReadLine());
                if (notaAtual < intervaloAceito[0] || notaAtual > intervaloAceito[1])
                    Console.WriteLine("nota invalida");
                else
                {
                    somaNotasValidas += notaAtual;
                    notasValidas++;
                }
            }
            double media = (somaNotasValidas / notasValidas);
            Console.WriteLine(string.Format("media = {0}", media.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)));
        }
        static void _1116()
        {
            int leituras = int.Parse(Console.ReadLine());
            double[][] valores = new double[leituras][];
            for (int i = 0; i < leituras; i++)
            {
                string[] vet = Console.ReadLine().Split(' '); ;
                double va = int.Parse(vet[0]);
                double vb = int.Parse(vet[1]);
                valores[i] = new double[]
                {
                    va, vb
                };
            }
            for (int i = 0; i < leituras; i++)
            {
                if (valores[i][1] == 0)
                    Console.WriteLine("divisao impossivel");
                else
                    Console.WriteLine((valores[i][0] / valores[i][1]).ToString("F1", System.Globalization.CultureInfo.InvariantCulture));
            }
        }
        static void _1115()
        {
            string[] coordenadas = Console.ReadLine().Split(' ');
            int x = int.Parse(coordenadas[0]);
            int y = int.Parse(coordenadas[1]);
            while (x * y != 0)
            {
                if (x > 0 && y > 0)
                    Console.WriteLine("primeiro");
                else if (x < 0 && y > 0)
                    Console.WriteLine("segundo");
                else if (x < 0 && y < 0)
                    Console.WriteLine("terceiro");
                else
                    Console.WriteLine("quarto");
                coordenadas = Console.ReadLine().Split(' ');
                x = int.Parse(coordenadas[0]);
                y = int.Parse(coordenadas[1]);
            }
        }
        static void _1114()
        {
            while (int.Parse(Console.ReadLine()) != 2002)
                Console.WriteLine("Senha Invalida");
            Console.WriteLine("Acesso Permitido");
        }
        static void _1101()
        {
            string[] vetor = Console.ReadLine().Split(' ');
            int a = int.Parse(vetor[0]);
            int b = int.Parse(vetor[1]);
            while (a * b > 0)
            {
                int[] valores = new int[] { a, b };
                Array.Sort(valores);
                int somaValores = 0;
                int count = valores[0];
                do
                {
                    Console.Write(string.Format("{0} ", count));
                    somaValores += count++;
                } while (count <= valores[1]);
                Console.WriteLine(string.Format("Sum={0}", somaValores));
                vetor = Console.ReadLine().Split(' ');
                a = int.Parse(vetor[0]);
                b = int.Parse(vetor[1]);
            }
        }
        static void _1099()
        {
            int N = int.Parse(Console.ReadLine());
            int[][] valores = new int[N][];
            for (int i = 0; i < N; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                valores[i] = new int[]
                {
                    int.Parse(vetor[0]),
                    int.Parse(vetor[1])
                };
                Array.Sort(valores[i]);
            }
            foreach (var valor in valores)
            {
                int v1 = valor[0];
                int v2 = valor[1];
                int count = v1;
                count++;
                int somaImpares = 0;
                while (v1 < count && count < v2)
                {
                    if (count % 2 != 0)
                        somaImpares += count;
                    count++;
                }
                Console.WriteLine(somaImpares);
            }
        }
        static void _1098()
        {
            double i = 0;
            double j1 = 1;
            double j2 = j1;
            double fator = 0.2;
            while (i <= 2)
            {
                int count = 0;
                while (count < 3)
                {
                    Console.WriteLine(string.Format("I={0} J={1}", i.ToString(System.Globalization.CultureInfo.InvariantCulture), j1.ToString(System.Globalization.CultureInfo.InvariantCulture)));
                    j1 += 1;
                    count++;
                }
                i += fator;
                j1 = j2 + fator;
                j2 = j1;
            }
            Console.ReadLine();
        }
        static void _1097()
        {
            int i = 1;
            int j1 = 7;
            int j2 = 7;
            while (i <= 9)
            {
                while (j1 >= j2 - 2)
                {
                    Console.WriteLine(string.Format("I={0} J={1}", i, j1));
                    j1--;
                }
                i += 2;
                j1 = j2 + 2;
                j2 = j1;
            }
        }
        static void _1096()
        {
            int i = 1;
            int j = 7;
            while (i <= 9)
            {
                while (j >= 5)
                {
                    Console.WriteLine(string.Format("I={0} J={1}", i, j));
                    j--;
                }
                i += 2;
                j = 7;
            }
        }
        static void _1095()
        {
            int i = 1;
            int j = 60;
            while (j >= 0)
            {
                Console.WriteLine(string.Format("I={0} J={1}", i, j));
                i += 3;
                j -= 5;
            }
        }
        static void _1094()
        {
            int somaCobaias = 0;
            int[] estatisticas = new int[3];
            int testes = int.Parse(Console.ReadLine());
            for (int i = 0; i < testes; i++)
            {
                string[] leitura = Console.ReadLine().Split(' ');
                somaCobaias += int.Parse(leitura[0]);
                estatisticas[leitura[1].ToUpper() == "C" ? 0 : leitura[1].ToUpper() == "R" ? 1 : 2] += int.Parse(leitura[0]);
            }
            double percentualCoelhos = ((double)estatisticas[0] / somaCobaias) * 100.0;
            double percentualRatos = ((double)estatisticas[1] / somaCobaias) * 100.0;
            double percentualSapos = ((double)estatisticas[2] / somaCobaias) * 100.0;
            var texto = new System.Text.StringBuilder();
            texto.AppendLine(string.Format("Total: {0} cobaias", somaCobaias));
            texto.AppendLine(string.Format("Total de coelhos: {0}", estatisticas[0]));
            texto.AppendLine(string.Format("Total de ratos: {0}", estatisticas[1]));
            texto.AppendLine(string.Format("Total de sapos: {0}", estatisticas[2]));
            texto.AppendLine(string.Format("Percentual de coelhos: {0} %", percentualCoelhos.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)));
            texto.AppendLine(string.Format("Percentual de ratos: {0} %", percentualRatos.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)));
            texto.Append(string.Format("Percentual de sapos: {0} %", percentualSapos.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)));
            Console.WriteLine(texto.ToString());
        }
        static void _1080()
        {
            int posicao = 0;
            int maior = 0;
            for (int i = 1; i <= 100; i++)
            {
                int lido = int.Parse(Console.ReadLine());
                if (lido > maior)
                {
                    maior = lido;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
        static void _1079()
        {
            int testes = int.Parse(Console.ReadLine());
            double[] medias = new double[testes];
            for (int i = 0; i < testes; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double v1 = double.Parse(valores[0]);
                double v2 = double.Parse(valores[1]);
                double v3 = double.Parse(valores[2]);
                medias[i] = (v1 * 2 + v2 * 3 + v3 * 5) / 10;
            }
            foreach (var media in medias)
                Console.WriteLine(media.ToString("F1", System.Globalization.CultureInfo.InvariantCulture));
        }
        static void _1078()
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(string.Format("{0} x {1} = {2}", i, N, i * N));
        }
        static void _1075()
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10000; i++)
                if (i % N == 2)
                    Console.WriteLine(i);
        }
        static void _1074()
        {
            int N = int.Parse(Console.ReadLine());
            int[] valores = new int[N];
            for (int i = 0; i < N; i++)
                valores[i] = int.Parse(Console.ReadLine());
            foreach (var valor in valores)
            {
                if (valor == 0)
                {
                    Console.WriteLine("NULL");
                    continue;
                }
                if (valor % 2 == 0)
                    Console.Write("EVEN ");
                else
                    Console.Write("ODD ");
                if (valor > 0)
                    Console.WriteLine("POSITIVE");
                else
                    Console.WriteLine("NEGATIVE");
            }
        }
        static void _1073()
        {
            int N = int.Parse(Console.ReadLine());
            int count = 1;
            while (count <= N)
            {
                if (count % 2 == 0)
                    Console.WriteLine(string.Format("{0}^2 = {1}", count, count * count));
                count++;
            }
        }
        static void _1072()
        {
            int testes = int.Parse(Console.ReadLine());
            int[] valores = new int[testes];
            for (int i = 0; i < testes; i++)
                valores[i] = int.Parse(Console.ReadLine());
            int _in = 0;
            int _out = 0;
            foreach (var valor in valores)
            {
                if (valor >= 10 && valor <= 20)
                    _in++;
                else
                    _out++;
            }
            Console.WriteLine(string.Format("{0} in", _in));
            Console.WriteLine(string.Format("{0} out", _out));
        }
        static void _1071()
        {
            int[] ordem = new int[]
            {
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine())
            };
            Array.Sort(ordem);
            int somaImpares = 0;
            for (int i = ordem[0] + 1; i < ordem[1]; i++)
            {
                if (i % 2 != 0)
                {
                    somaImpares += i;
                }
            }
            Console.WriteLine(somaImpares);
        }
        static void _1070()
        {
            int valor = int.Parse(Console.ReadLine());
            int count = 0;
            int[] impares = new int[6];
            while (count < 6)
            {
                if (valor % 2 != 0)
                {
                    impares[count++] = valor;
                }
                valor++;
            }
            foreach (var numero in impares)
                Console.WriteLine(numero);
        }
        static void _1067()
        {
            int valor = int.Parse(Console.ReadLine());
            for (int i = 1; i <= valor; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
        }
        static void _1066()
        {
            double[] range = new double[]
            {
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine())
            };
            int pares = 0;
            foreach (var valor in range)
                pares += valor % 2 == 0 ? 1 : 0;
            Console.WriteLine(string.Format("{0} valor(es) par(es)", pares));

            int impares = 0;
            foreach (var valor in range)
                impares += valor % 2 != 0 ? 1 : 0;
            Console.WriteLine(string.Format("{0} valor(es) impar(es)", impares));

            int positivo = 0;
            foreach (var valor in range)
                positivo += valor > 0 ? 1 : 0;
            Console.WriteLine(string.Format("{0} valor(es) positivo(s)", positivo));

            int negatio = 0;
            foreach (var valor in range)
                negatio += valor < 0 ? 1 : 0;
            Console.WriteLine(string.Format("{0} valor(es) negativo(s)", negatio));
        }
        static void _1065()
        {
            double[] range = new double[]
            {
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine())
            };
            int pares = 0;
            foreach (var valor in range)
                pares += valor % 2 == 0 ? 1 : 0;
            Console.WriteLine(string.Format("{0} valores pares", pares));
        }
        static void _1064()
        {
            double[] range = new double[]
            {
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
            };
            int positivos = 0;
            double soma = 0;
            foreach (var valor in range)
            {
                if (valor > 0)
                {
                    positivos += 1;
                    soma += valor;
                }
            }
            Console.WriteLine(string.Format("{0} valores positivos", positivos));
            Console.WriteLine((soma / positivos).ToString("F1", System.Globalization.CultureInfo.InvariantCulture));
        }
        static void _1060()
        {
            double[] range = new double[]
            {
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
            };
            int positivos = 0;
            foreach (var valor in range)
                positivos += valor > 0 ? 1 : 0;
            Console.WriteLine(string.Format("{0} valores positivos", positivos));
        }
        static void _1059()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void _1052()
        {
            int mes = int.Parse(Console.ReadLine());
            var meses = new System.Collections.Generic.Dictionary<int, string>()
            {
                {1, "January" },
                {2, "February" },
                {3, "March" },
                {4, "April" },
                {5, "May" },
                {6, "June" },
                {7, "July" },
                {8, "August" },
                {9, "September" },
                {10, "October" },
                {11, "November" },
                {12, "December" },
            };
            Console.WriteLine(meses[mes]);
        }
        static void _1051()
        {
            double salario = double.Parse(Console.ReadLine());
            if (salario <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                double resto = salario;
                double imposto = 0;
                double[][] faixas = new double[][]
                {
                    new double[] { 4500, 0.28 },
                    new double[] { 3000, 0.18 },
                    new double[] { 2000, 0.08 },
                };
                foreach (var faixa in faixas)
                {
                    if (resto > faixa[0])
                    {
                        double tributado = resto - faixa[0];
                        double taxa = faixa[1];
                        imposto += tributado * taxa;
                        resto = faixa[0];
                    }
                }
                Console.WriteLine(string.Format("R$ {0}", imposto.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)));
            }
        }
        static void _1050()
        {
            int ddd = int.Parse(Console.ReadLine());
            var catalogo = new System.Collections.Generic.Dictionary<int, string>()
            {
                { 61, "Brasilia" },
                { 71, "Salvador" },
                { 11, "Sao Paulo"},
                { 21, "Rio de Janeiro"},
                { 32, "Juiz de Fora"},
                { 19, "Campinas"},
                { 27, "Vitoria"},
                { 31, "Belo Horizonte"}
            };
            try
            {
                string cidade = catalogo[ddd];
                Console.WriteLine(cidade);
            }
            catch (Exception)
            {
                Console.WriteLine("DDD nao cadastrado");
            }
        }
        static void _1049()
        {
            string nivel1 = Console.ReadLine();
            string nivel2 = Console.ReadLine();
            string nivel3 = Console.ReadLine();
            if (nivel1 == "vertebrado")
            {
                if (nivel2 == "ave")
                {
                    if (nivel3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (nivel3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (nivel2 == "mamifero")
                {
                    if (nivel3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (nivel3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (nivel1 == "invertebrado")
            {
                if (nivel2 == "inseto")
                {
                    if (nivel3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (nivel3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (nivel2 == "anelideo")
                {
                    if (nivel3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (nivel3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
        static void _1048()
        {
            var format = System.Globalization.CultureInfo.InvariantCulture;
            var ranges = new System.Collections.Generic.Dictionary<double, double[]>()
            {
                {0.15, new double[] { -0.01, 400 } },
                {0.12, new double[] { 400, 800 } },
                {0.10, new double[] { 800, 1200 } },
                {0.07, new double[] { 1200, 2000 } },
                {0.04, new double[] { 2000, double.MaxValue } },
            };
            double salarioAtual = double.Parse(Console.ReadLine());
            double percentual = 0;
            foreach (var acrescimo in ranges)
                if (salarioAtual > acrescimo.Value[0] && salarioAtual <= acrescimo.Value[1])
                    percentual = acrescimo.Key;
            double novoSalario = salarioAtual * (1.0 + percentual);
            double reajuste = novoSalario - salarioAtual;
            Console.WriteLine(string.Format("Novo salario: {0}", novoSalario.ToString("F2", format)));
            Console.WriteLine(string.Format("Reajuste ganho: {0}", reajuste.ToString("F2", format)));
            Console.WriteLine(string.Format("Em percentual: {0} %", (percentual * 100).ToString("F0", format)));
        }
        static void _1047()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(valores[0]);
            int minutoInicio = int.Parse(valores[1]);
            int horaTermino = int.Parse(valores[2]);
            int minutoTermino = int.Parse(valores[3]);
            TimeSpan h1 = new TimeSpan(horaInicio, minutoInicio, 0);
            TimeSpan h2 = new TimeSpan(horaTermino, minutoTermino, 0);
            if (h2 <= h1)
                h2 = h2.Add(new TimeSpan(1, 0, 0, 0));
            TimeSpan duracao = h2 - h1;
            int horasTotais = (int)(duracao.TotalMinutes / 60);
            int minutosTotais = (int)(duracao.TotalMinutes - horasTotais * 60);
            minutosTotais = horasTotais < 0 ? minutosTotais < 1 ? 1 : minutosTotais : minutosTotais;
            Console.WriteLine(string.Format("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horasTotais, minutosTotais));
        }
        static void _1046()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(valores[0]);
            int horaTermino = int.Parse(valores[1]);
            TimeSpan h1 = new TimeSpan(horaInicio, 0, 0);
            TimeSpan h2;
            if (horaTermino > horaInicio)
                h2 = new TimeSpan(horaTermino, 0, 0);
            else
                h2 = new TimeSpan(1, horaTermino, 0, 0);
            TimeSpan duracao = h2 - h1;
            Console.WriteLine(string.Format("O JOGO DUROU {0} HORA(S)", duracao.TotalHours));
        }
        static void _1045()
        {
            string[] valores = Console.ReadLine().Split(' ');
            var A = double.Parse(valores[0]);
            var B = double.Parse(valores[1]);
            var C = double.Parse(valores[2]);
            double[] numeros = new double[] { A, B, C };
            Array.Sort(numeros, new Comparison<double>((i1, i2) => i2.CompareTo(i1)));
            A = numeros[0];
            B = numeros[1];
            C = numeros[2];
            var f1 = A >= B + C;
            var f2 = Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2);
            var f3 = Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2);
            var f4 = Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2);
            var f5 = A == B && B == C;
            var f6 = (A == B && B != C) || (A == C && C != B) || (B == C && C != A);
            if (f1)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
                return;
            }
            if (f2)
                Console.WriteLine("TRIANGULO RETANGULO");
            if (f3)
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            if (f4)
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (f5)
                Console.WriteLine("TRIANGULO EQUILATERO");
            if (f6)
                Console.WriteLine("TRIANGULO ISOSCELES");
        }
        static void _1044()
        {
            string[] valores = Console.ReadLine().Split(' ');
            var A = int.Parse(valores[0]);
            var B = int.Parse(valores[1]);
            var numeros = new int[] { A, B };
            Array.Sort(numeros);
            double resto = numeros[1] % numeros[0];
            if (resto == 0)
                Console.WriteLine("Sao Multiplos");
            else
                Console.WriteLine("Nao sao Multiplos");
        }
        static void _1043()
        {
            string[] valores = Console.ReadLine().Split(' ');
            var A = double.Parse(valores[0]);
            var B = double.Parse(valores[1]);
            var C = double.Parse(valores[2]);
            double[] numeros = new double[] { A, B, C };
            Array.Sort(numeros);
            var area = Math.Round(((A + B) * C) / 2.0, 1);
            var perimetro = Math.Round(A + B + C, 1);
            if (numeros[2] >= numeros[0] + numeros[1])
                Console.WriteLine(string.Format("Area = {0}", area.ToString("F1")));
            else
                Console.WriteLine(string.Format("Perimetro = {0}", perimetro.ToString("F1")));
        }
        static void _1042()
        {
            var lista = new System.Collections.Generic.List<int>();
            string[] entrada = Console.ReadLine().Split(' ');
            int A = int.Parse(entrada[0]);
            int B = int.Parse(entrada[1]);
            int C = int.Parse(entrada[2]);
            int[] numeros = new int[] { A, B, C };
            Array.Sort(numeros);
            foreach (var item in numeros)
                Console.WriteLine(item);
            Console.WriteLine();
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
        static void _1041()
        {
            string[] coordenadas = Console.ReadLine().Split(' ');
            double x = double.Parse(coordenadas[0]);
            double y = double.Parse(coordenadas[1]);

            if (x == 0 && y == 0)
                Console.WriteLine("Origem");
            else if (x == 0 && y != 0)
                Console.WriteLine("Eixo Y");
            else if (x != 0 && y == 0)
                Console.WriteLine("Eixo X");
            else if (x > 0 && y > 0)
                Console.WriteLine("Q1");
            else if (x < 0 && y > 0)
                Console.WriteLine("Q2");
            else if (x < 0 && y < 0)
                Console.WriteLine("Q3");
            else
                Console.WriteLine("Q4");
        }
        static class _1061
        {
            public static void Problema()
            {
                int diaInicio = VerificarDia(Console.ReadLine());
                DateTime horarioInicio = CriarDateTimeOcorrencia(Console.ReadLine(), diaInicio);
                int diaEncerramento = VerificarDia(Console.ReadLine(), diaInicio);
                DateTime horarioEncerramento = CriarTimeSpanOcorrencia(Console.ReadLine(), diaEncerramento, horarioInicio);
                TimeSpan periodo = horarioEncerramento - horarioInicio;
                Console.WriteLine(string.Format("{0} dia(s)", periodo.Days));
                Console.WriteLine(string.Format("{0} hora(s)", periodo.Hours));
                Console.WriteLine(string.Format("{0} minuto(s)", periodo.Minutes));
                Console.WriteLine(string.Format("{0} segundo(s)", periodo.Seconds));
            }

            private static int VerificarDia(string sdia, int diaMinimo = 1)
            {
                int dia = int.Parse(sdia.Split(' ')[1]);
                if (dia >= diaMinimo && dia >= 1 && dia <= 31)
                    return dia;
                throw new Exception();
            }

            private static DateTime CriarDateTimeOcorrencia(string horario, int diaMes)
            {
                return CriarTimeSpanOcorrencia(horario, diaMes, new DateTime());
            }

            private static DateTime CriarTimeSpanOcorrencia(string horario, int diaMes, DateTime dataInicio)
            {
                int horas = int.Parse(horario.Split(':')[0]);
                int minutos = int.Parse(horario.Split(':')[1]);
                int segundos = int.Parse(horario.Split(':')[2]);
                if (horas >= 0 && horas <= 23)
                {
                    if (minutos >= 0 && minutos <= 59)
                    {
                        if (segundos >= 0 && segundos <= 59)
                        {
                            DateTime result = new DateTime(1, 1, diaMes, horas, minutos, segundos);
                            if (result >= dataInicio)
                            {
                                return result;
                            }
                        }
                    }
                }
                throw new Exception();
            }
        }
        static void _1040()
        {
            var invariantCulture = System.Globalization.CultureInfo.InvariantCulture;
            string[] notas = Console.ReadLine().Split(' ');
            double[] n1 = new double[] { double.Parse(notas[0]), 2.0 };
            double[] n2 = new double[] { double.Parse(notas[1]), 3.0 };
            double[] n3 = new double[] { double.Parse(notas[2]), 4.0 };
            double[] n4 = new double[] { double.Parse(notas[3]), 1.0 };
            double media1 = (n1[0] * n1[1] + n2[0] * n2[1] + n3[0] * n3[1] + n4[0] * n4[1]) / (n1[1] + n2[1] + n3[1] + n4[1]);
            media1 = Math.Round(media1, 1);
            Console.WriteLine(string.Format("Media: {0}", media1.ToString("F1", invariantCulture)));
            if (media1 >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
                return;
            }
            else if (media1 < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
                return;
            }
            Console.WriteLine("Aluno em exame.");
            double notaExame = double.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("Nota do exame: {0}", notaExame.ToString("F1", invariantCulture)));
            double media2 = (media1 + notaExame) / 2;
            media2 = Math.Round(media2, 1);
            if (media2 >= 5.0)
                Console.WriteLine("Aluno aprovado.");
            else
                Console.WriteLine("Aluno reprovado.");
            Console.WriteLine(string.Format("Media final: {0}", media2.ToString("F1", invariantCulture)));
        }
        static void _1038()
        {
            var format = System.Globalization.CultureInfo.InvariantCulture;
            var Cardapio = new System.Collections.Generic.Dictionary<int, double>()
            {
                {1, 4.0},
                {2, 4.5},
                {3, 5.0},
                {4, 2.0},
                {5, 1.5},
            };
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);
            double total = quantidade * Cardapio[codigo];
            Console.WriteLine(string.Format("Total: R$ {0}", total.ToString("F2", format)));
        }
        static void _1037()
        {
            var intervalos = new System.Collections.Generic.Dictionary<string, double[]>()
            {
                {"[0,25]", new double[2] { 0 - 0.0000000000000000000000000000000000001, 25 } },
                {"(25,50]", new double[2] { 25, 50 } },
                {"(75,100]", new double[2] { 50, 100 } },
            };
            double variavel = double.Parse(Console.ReadLine());
            foreach (var intervalo in intervalos)
            {
                if (variavel > intervalo.Value[0] && variavel <= intervalo.Value[1])
                {
                    Console.WriteLine(string.Format("Intervalo {0}", intervalo.Key));
                    return;
                }
            }
            Console.WriteLine("Fora de intervalo");
        }
        static void _1036()
        {
            try
            {
                string[] VALORES = Console.ReadLine().Split(' ');
                double a = double.Parse(VALORES[0]);
                double b = double.Parse(VALORES[1]);
                double c = double.Parse(VALORES[2]);
                double[] RAIZES = new double[2];
                double delta = -4.0 * a * c + Math.Pow(b, 2);
                RAIZES[0] = (-b + Math.Sqrt(delta)) / (2.0 * a);
                RAIZES[1] = (-b - Math.Sqrt(delta)) / (2.0 * a);
                if (double.IsNaN(RAIZES[0]) || double.IsNaN(RAIZES[1]))
                    throw new Exception();
                for (int i = 0; i < 2; i++)
                    Console.WriteLine(string.Format("R{0} = {1}", i + 1, RAIZES[i].ToString("F5", System.Globalization.CultureInfo.InvariantCulture)));
            }
            catch (Exception)
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
        static void _1035()
        {
            string[] VALORES = Console.ReadLine().Split(' ');
            int A = int.Parse(VALORES[0]);
            int B = int.Parse(VALORES[1]);
            int C = int.Parse(VALORES[2]);
            int D = int.Parse(VALORES[3]);
            bool flag1 = B > C;
            bool flag2 = D > A;
            bool flag3 = (C + D) > (A + B);
            bool flag4 = C >= 0;
            bool flag5 = D >= 0;
            bool flag6 = A % 2 == 0;
            if (flag1 && flag2 && flag3 && flag4 && flag5 && flag6)
                Console.WriteLine("Valores aceitos");
            else
                Console.WriteLine("Valores nao aceitos");
        }
        static void _1021()
        {
            double VALOR = Math.Round(double.Parse(Console.ReadLine()), 2);
            double[][] notasUtilizadas = new double[6][];
            double[][] moedasUtilizadas = new double[6][];
            double[] notasDisponiveis = new double[] { 100, 50, 20, 10, 5, 2 };
            double[] moedasDisponiveis = new double[] { 100, 50, 25, 10, 5, 1 };
            double resto = VALOR;
            for (int i = 0; i < notasDisponiveis.Length; i++)
            {
                if (resto >= notasDisponiveis[i])
                {
                    double qtdNotas = (int)(resto / notasDisponiveis[i]);
                    resto -= notasDisponiveis[i] * qtdNotas;
                    notasUtilizadas[i] = new double[]
                    {
                        notasDisponiveis[i], qtdNotas
                    };
                }
                else
                {
                    notasUtilizadas[i] = new double[]
                    {
                        notasDisponiveis[i], 0
                    };
                }
            }
            resto = (int)(resto * 100);
            for (int i = 0; i < moedasDisponiveis.Length; i++)
            {
                if (resto >= moedasDisponiveis[i])
                {
                    double qtdMoedas = (int)(resto / moedasDisponiveis[i]);
                    resto -= moedasDisponiveis[i] * qtdMoedas;
                    moedasUtilizadas[i] = new double[]
                    {
                        moedasDisponiveis[i], qtdMoedas
                    };
                }
                else
                {
                    moedasUtilizadas[i] = new double[]
                    {
                        moedasDisponiveis[i], 0
                    };
                }
            }
            string textoNotas = "{0} nota(s) de R$ {1}";
            string textoMoedas = "{0} moeda(s) de R$ {1}";
            Console.WriteLine("NOTAS:");
            foreach (var nota in notasUtilizadas)
            {
                Console.WriteLine(string.Format(textoNotas, nota[1], nota[0].ToString("F2", System.Globalization.CultureInfo.InvariantCulture)));
            }
            Console.WriteLine("MOEDAS:");
            foreach (var moeda in moedasUtilizadas)
            {
                Console.WriteLine(string.Format(textoMoedas, moeda[1], (moeda[0] / 100).ToString("F2", System.Globalization.CultureInfo.InvariantCulture)));
            }
        }
        static void _1020()
        {
            int N = int.Parse(Console.ReadLine());
            int[] periodos = new int[] { 365, 30, 1 };
            int[] idadeConvertida = new int[3];
            for (int i = 0; i < periodos.Length; i++)
            {
                if (N >= periodos[i])
                {
                    int var1 = N / periodos[i];
                    idadeConvertida[i] = var1;
                    N -= var1 * periodos[i];
                }
            }
            Console.WriteLine(string.Format("{0} ano(s)", idadeConvertida[0]));
            Console.WriteLine(string.Format("{0} mes(es)", idadeConvertida[1]));
            Console.WriteLine(string.Format("{0} dia(s)", idadeConvertida[2]));
        }
        static void _1019()
        {
            int N = int.Parse(Console.ReadLine());
            int resto = N;
            int[] temposConvertidos = new int[3];
            int[] temposDisponiveis = new int[] { 3600, 60, 1 };
            for (int i = 0; i < temposDisponiveis.Length; i++)
            {
                if (resto >= temposDisponiveis[i])
                {
                    int qtdTempos = (int)Math.Floor((double)resto / temposDisponiveis[i]);
                    resto -= qtdTempos * temposDisponiveis[i];
                    temposConvertidos[i] = qtdTempos;
                }
                else
                {
                    temposConvertidos[i] = 0;
                }
            }
            string texto = "{0}:{1}:{2}";
            Console.WriteLine(string.Format(texto, temposConvertidos[0], temposConvertidos[1], temposConvertidos[2]));
        }
        static void _1018()
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);
            int[][] notasTrocadas = new int[7][];
            int resto = N;
            int[] notasDisponiveis = new int[] { 100, 50, 20, 10, 5, 2, 1 };
            for (int i = 0; i < notasDisponiveis.Length; i++)
            {
                if (resto >= notasDisponiveis[i])
                {
                    int qtdNotas = (int)Math.Floor((double)resto / notasDisponiveis[i]);
                    resto -= qtdNotas * notasDisponiveis[i];
                    notasTrocadas[i] = new int[2];
                    notasTrocadas[i][0] = notasDisponiveis[i];
                    notasTrocadas[i][1] = qtdNotas;
                }
                else
                {
                    notasTrocadas[i] = new int[2];
                    notasTrocadas[i][0] = notasDisponiveis[i];
                    notasTrocadas[i][1] = 0;
                }
            }
            string texto = "{0} nota(s) de R$ {1},00";
            foreach (var nota in notasTrocadas)
            {
                Console.WriteLine(string.Format(texto, nota[1], nota[0]));
            }
        }
        static void _1017()
        {
            int tempoGasto = int.Parse(Console.ReadLine());
            int velocidadeMedia = int.Parse(Console.ReadLine());
            int kmL = 12;
            int distancia = tempoGasto * velocidadeMedia;
            double combustivelGasto = (double)distancia / kmL;
            Console.WriteLine(combustivelGasto.ToString("F3", System.Globalization.CultureInfo.InvariantCulture));
        }
        static void _1016()
        {
            int DISTANCIA = int.Parse(Console.ReadLine());
            int TIME = (60 * DISTANCIA) / 30;
            string texto = "{0} minutos";
            Console.WriteLine(string.Format(texto, TIME));
        }
        static void _1015()
        {
            string[] P1 = Console.ReadLine().Split(' ');
            string[] P2 = Console.ReadLine().Split(' ');
            double[][] DADOS = new double[][]
            {
                new double[]
                {
                    double.Parse(P1[0]),
                    double.Parse(P1[1])
                },
                new double[]
                {
                    double.Parse(P2[0]),
                    double.Parse(P2[1])
                }
            };
            double DISTANCIA = Math.Sqrt(Math.Pow(DADOS[1][0] - DADOS[0][0], 2) + Math.Pow(DADOS[1][1] - DADOS[0][1], 2));
            Console.WriteLine(DISTANCIA.ToString("F4", System.Globalization.CultureInfo.InvariantCulture));
        }
        static void _1014()
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            double consumoMedio = X / Y;
            Console.WriteLine(string.Format("{0} km/l", consumoMedio.ToString("F3", System.Globalization.CultureInfo.InvariantCulture)));
        }
        static void _1013()
        {
            string[] VALORES = Console.ReadLine().Split(' ');
            int A = int.Parse(VALORES[0]);
            int B = int.Parse(VALORES[1]);
            int C = int.Parse(VALORES[2]);
            int maiorAB = (A + B + Math.Abs(A - B)) / 2;
            int maiorABC = maiorAB > C ? maiorAB : C;
            string texto = "{0} eh o maior";
            Console.WriteLine(string.Format(texto, maiorABC));
        }
        static void _1012()
        {
            double pi = 3.14159;
            string[] VALORES = Console.ReadLine().Split(' ');
            double A = double.Parse(VALORES[0]);
            double B = double.Parse(VALORES[1]);
            double C = double.Parse(VALORES[2]);
            System.Collections.Generic.Dictionary<string, double> VARIAVEIS = new System.Collections.Generic.Dictionary<string, double>();
            {
                VARIAVEIS.Add("TRIANGULO", (A * C) / 2);
                VARIAVEIS.Add("CIRCULO", pi * Math.Pow(C, 2.0));
                VARIAVEIS.Add("TRAPEZIO", ((A + B) * C) / 2);
                VARIAVEIS.Add("QUADRADO", Math.Pow(B, 2));
                VARIAVEIS.Add("RETANGULO", A * B);
            }
            foreach (var item in VARIAVEIS)
                Console.WriteLine(string.Format("{0}: {1}", item.Key, item.Value.ToString("F3", System.Globalization.CultureInfo.InvariantCulture)));
        }
        static void _1011()
        {
            double pi = 3.14159;
            double R = double.Parse(Console.ReadLine());
            string texto = "VOLUME = {0}";
            double volume = (4.0 / 3.0) * pi * Math.Pow(R, 3);
            Console.WriteLine(string.Format(texto, volume.ToString("F3", System.Globalization.CultureInfo.InvariantCulture)));
        }
        static void _1010()
        {
            System.Collections.ArrayList[] listaPecas = new System.Collections.ArrayList[2];
            for (int i = 0; i < 2; i++)
            {
                var novaPeca = new System.Collections.ArrayList();
                var VETOR = Console.ReadLine().Split(' ');
                novaPeca.Add(int.Parse(VETOR[0]));
                novaPeca.Add(int.Parse(VETOR[1]));
                novaPeca.Add(double.Parse(VETOR[2]));
                listaPecas[i] = novaPeca;
            }
            double valorPagar = 0;
            for (int i = 0; i < listaPecas.Length; i++)
            {
                valorPagar += double.Parse((listaPecas[i][1].ToString())) * double.Parse(listaPecas[i][2].ToString());
            }
            string texto = "VALOR A PAGAR: R$ {0}";
            Console.WriteLine(string.Format(texto, valorPagar.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)));
        }
        static void _1009()
        {
            string nome = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine());
            double vendas = double.Parse(Console.ReadLine());
            double comissao = 0.15;
            double salario = salarioFixo + vendas * comissao;
            Console.WriteLine(string.Format("TOTAL = R$ {0}", salario.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)));
        }
        static void _1008()
        {
            int number = int.Parse(Console.ReadLine());
            double qtHoras = double.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine());
            double salario = qtHoras * valorHora;
            Console.WriteLine(string.Format("NUMBER = {0}", number));
            Console.WriteLine(string.Format("SALARY = U$ {0}", salario.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)));
        }
        static void _1007()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int prodAB = A * B;
            int prodCD = C * D;
            Console.WriteLine(string.Format("DIFERENCA = {0}", prodAB - prodCD));
        }
        static void _1006()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double MEDIA = (A * 2 + B * 3 + C * 5) / 10.0;
            Console.WriteLine(string.Format("MEDIA = {0}", MEDIA.ToString("F1", System.Globalization.CultureInfo.InvariantCulture)));
        }
        static void _1005()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double MEDIA = (A * 3.5 + B * 7.5) / 11.0;
            Console.WriteLine(string.Format("MEDIA = {0}", MEDIA.ToString("F5", System.Globalization.CultureInfo.InvariantCulture)));
        }
        static void _1004()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int PROD = A * B;
            Console.WriteLine(string.Format("PROD = {0}", PROD));
        }
        static void _1003()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int SOMA = A + B;
            Console.WriteLine(string.Format("SOMA = {0}", SOMA));
        }
        static void _1002()
        {
            double n = 3.14159;
            double raio = double.Parse(Console.ReadLine());
            double area = n * Math.Pow(raio, 2.0);
            Console.WriteLine(string.Format("A={0}", area.ToString("F4", System.Globalization.CultureInfo.InvariantCulture)));
        }
        static void _1001()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int X = A + B;
            Console.WriteLine("X = " + X);
        }
        #region Matrizes
        static void _m2()
        {
            string[] s = Console.ReadLine().Split(' ');
            int N = int.Parse(s[0]);
            int M = int.Parse(s[1]);
            int[,] M1 = new int[N, M];
            int[,] M2 = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++)
                    M1[i, j] = int.Parse(valores[j]);
            }

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++)
                    M2[i, j] = int.Parse(valores[j]);
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(M1[i, j] + M2[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        static void _m1()
        {
            var f = System.Globalization.CultureInfo.InvariantCulture;
            int N = int.Parse(Console.ReadLine());
            double[,] A = new double[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                    A[i, j] = double.Parse(valores[j]);
            }

            double soma = 0;
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    if (A[i, j] > 0)
                        soma += A[i, j];
            Console.WriteLine(string.Format("SOMA DOS POSITIVOS: {0}", soma.ToString("F1", f)));

            int Le = int.Parse(Console.ReadLine());
            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 0; i < N; i++)
                Console.Write(A[Le, i].ToString("F1", f) + " ");
            Console.WriteLine();

            int Ce = int.Parse(Console.ReadLine());
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < N; i++)
                Console.Write(A[i, Ce].ToString("F1", f) + " ");
            Console.WriteLine();

            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
                Console.Write(A[i, i].ToString("F1", f) + " ");
            Console.WriteLine();

            Console.WriteLine("MATRIZ ALTERADA: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] < 0)
                        A[i, j] = Math.Pow(A[i, j], 2);
                    Console.Write(A[i, j].ToString("F1", f) + " ");
                }
                Console.WriteLine();
            }
        }
        #endregion
        #endregion

    }
}
