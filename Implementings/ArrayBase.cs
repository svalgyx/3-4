using HW3_4.Interfaces;

namespace HW3_4.Implementings
{
    public abstract class ArrayBase<T> : IArrayBase
    {
        protected static TypeHelper<T> type_helper;
        public bool Init { get; }

        public abstract void Print();

        protected abstract void RandomCreate();

        protected abstract void UserCreate();

        public ArrayBase(string init)
        {
            type_helper = new TypeHelper<T>();
            if (init == "N")
            {
                UserCreate();
            } else {
                RandomCreate();
            }
        }
    }
}
