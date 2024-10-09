int N = int.Parse(Console.ReadLine());
int[] arr = new int[N];
    for (int i = 0; i < N; i++)
        {
            arr[i] = 2 * i + 1; // нечетные числа: 1, 3, 5...
        }
    for (int i = 0; i < N; i++)
        {
            Console.Write(arr[i] + " ");
        }