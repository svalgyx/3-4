namespace HW3_4.Implementings
{
    public sealed class Jagged<T> : ArrayBase<T>
    {
        private int Rows { get; set; }
        private T[][] array;

        public Jagged(string init, int rows) : base(init)
        {
            Rows = rows;
            array = new T[rows][];
        }

        protected override void UserCreate() {
            for (int i = 0; i < Rows; i++)
            {
                string row = Console.ReadLine();
                string[] array_row = row.Split(' ');
                array[i] = new T[array_row.Length];
                for (int j = 0; j < array_row.Length; j++)
                {
                    array[i][j] = type_helper.Convert(array_row[j]);
                }
            }
        }

        protected override void RandomCreate() {
            Random rnd = new Random();
            for (int i = 0; i < Rows; i++)
            {
                int array_row_len = rnd.Next(1, 10);
                array[i] = new T[array_row_len];
                for (int j = 0; j < array_row_len; j++)
                {
                    array[i][j] = type_helper.RandomValue();
                }
            }
        }

        public void Create()
        {
            if (base.Init)
            {
                UserCreate();
            }
            else
            {
                RandomCreate();
            }
        }

        public override void Print()
        {
            Console.WriteLine("jagged array: ");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
