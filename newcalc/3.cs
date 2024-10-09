int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());
int D = int.Parse(Console.ReadLine());

int[] firstColumn = new int[M];
        for (int i = 0; i < M; i++)
        {
            firstColumn[i] = int.Parse(Console.ReadLine());
        }

int[,] matrix = new int[M, N];
        for (int i = 0; i < M; i++)
        {
            matrix[i, 0] = firstColumn[i];
            for (int j = 1; j < N; j++)
            {
                matrix[i, j] = matrix[i, j - 1] + D;
            }
        }

        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }