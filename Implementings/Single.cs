namespace HW3_4.Implementings
{
    public sealed class Single<T> : ArrayBase<T>
    {
        private int Len { get; set; }
        private T[] array;
        public Single(string init, int len) : base(init)
        {
            Len = len;
            array = new T[len];
        }

        protected override void UserCreate() {
            string[] inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < Len; i++)
            {
                array[i] = type_helper.Convert(inputs[i]);
            }
        }

        protected override void RandomCreate() {
            Random rnd = new Random();
            for (int i = 0; i < Len; i++)
            {
                array[i] = type_helper.GenRandomValue();
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
            Console.WriteLine("single array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
