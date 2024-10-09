int N = int.Parse(Console.ReadLine());
int K = int.Parse(Console.ReadLine());
int[] arr = new int[N];

        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

int currentSeries = 1, seriesNumber = 1;
        for (int i = 1; i < N; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                currentSeries++;
            }
            else
            {
                if (seriesNumber == K)
                {
                    // Удваиваем серию K
                    for (int j = 0; j < currentSeries; j++)
                    {
                        Console.Write(arr[i - 1] + " ");
                    }
                }
                currentSeries = 1;
                seriesNumber++;
            }
            Console.Write(arr[i - 1] + " ");
        }