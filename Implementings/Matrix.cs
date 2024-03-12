namespace HW3_4.Implementings
    public sealed class Matrix<T> : ArrayBase<T>
    {
        private int Rows {  get; set; }
        private int Columns { get; set; }
        private T[,] array;
        public Matrix(string init, int rows, int columns) : base(init)
        {
            Rows = rows;
            Columns = columns;
            array = new T[rows, columns];
        }

        protected override void UserCreate() {
            for (int i = 0; i < Rows; i++)
            {
                string row = Console.ReadLine();
                string[] array_row = row.Split(' ');
                for (int j = 0; j < Columns; j++)
                {
                    array[i, j] = type_helper.Convert(array_row[j]);
                }
            }
        }

        protected override void RandomCreate() {
            Random rnd = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    array[i, j] = type_helper.GenRandomValue();
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
            Console.WriteLine("two-dimensional array: ");
            for (int i = 0; i < Rows; i++)
            {
                string row = "";
                for (int j = 0; j < Columns; j++)
                {
                    row += array[i, j] + " ";
                }
                Console.WriteLine(row);
            }
        }
    }
}
