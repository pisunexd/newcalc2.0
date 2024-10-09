int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

int[,] matrix = new int[M, N];

        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < M / 2; i++)
        {
            for (int j = 0; j < N / 2; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i + M / 2, j + N / 2];
                matrix[i + M / 2, j + N / 2] = temp;
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
