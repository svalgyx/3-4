namespace HW3_1
{
    class Jagged
    {
        private int rows = 0;
        private bool init = true;
        private int[][] arr;

        public Jagged(int input_rows, bool input_init = true)
        {
            rows = input_rows;
            init = input_init;
            arr = new int[rows][];
        }

        public void CreateNew()
        {
            if (init)
            {
                for (int i = 0; i < rows; i++)
                {
                    string row = Console.ReadLine();
                    string[] array_row = row.Split(' ');
                    arr[i] = new int[array_row.Length];
                    for (int j = 0; j < array_row.Length; j++)
                    {
                        arr[i][j] = int.Parse(array_row[j]);
                    }
                }
            }
            else
            {
                Random rnd = new Random();
                for (int i = 0; i < rows; i++)
                {
                    int array_row_len = rnd.Next(1, 10);
                    arr[i] = new int[array_row_len];
                    for (int j = 0; j < array_row_len; j++)
                    {
                        arr[i][j] = rnd.Next(1, 100);
                    }
                }
            }
        }

        public void WriteArray()
        {
            Console.WriteLine("Writing jagged array: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public double Average()
        {
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum += arr[i][j];
                    counter += 1;
                }
            }
            Console.WriteLine("Counted the average value of the array: ");
            return (double)sum / (double)counter;
        }

        public double[] AverageValues()
        {
            double[] average_values = new double[rows];
            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum += arr[i][j];
                }
                average_values[i] = (double)sum / (double)arr[i].Length;
            }
            Console.WriteLine(" average values of the array: ");
            return average_values;
        }

        public void NumsToo()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] % 2 == 0)
                    {
                        arr[i][j] = i * j;
                    }
                }
            }
            Console.WriteLine("Elements were changed too with multiplication of their indices: ");
        }
    }
}
