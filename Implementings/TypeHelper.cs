using HW3_4.Interfaces;

namespace HW3_4.Implementings
{
    public class TypeHelper<T> : ITypeHelper<T>
    {
        private static Random rnd = new Random();
        public T Convert(string input)
        {
            if (typeof(T) == typeof(int))
            {
                return (T)(object)int.Parse(input);
            }
            if (typeof(T) == typeof(double))
            {
                return (T)(object)double.Parse(input);
            }
            if (typeof(T) == typeof(bool))
            {
                return (T)(object)bool.Parse(input);
            }
            if (typeof(T) == typeof(string))
            {
                return (T)(object)input;
            }
            return default(T);
        }
        public int RandomInt()
        {
            int random_value = rnd.Next(1, 100);
            return random_value;
        }
        public string RandomString()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int letters = rnd.Next(1, 11);
            string random_string = "";
            for (int i = 0; i < letters; i++)
            {
                random_string += alphabet[rnd.Next(0, 26)];
            }
            return random_string;
        }
        public bool RandomBool()
        {
            int b = rnd.Next(0, 2);
            if (b == 0)
            {
                return false;
            }
            return true;
        }
        public double RandomDouble()
        {
            double random_double = rnd.NextDouble();
            return RandomInt() + random_double;
        }
        public T RandomValue()
        {
            if (typeof(T) == typeof(int))
            {
                return (T)(object)RandomInt();
            }
            if (typeof(T) == typeof(double))
            {
                return (T)(object)RandomDouble();
            }
            if (typeof(T) == typeof(bool))
            {
                return (T)(object)RandomBool();
            }
            if (typeof(T) == typeof(string))
            {
                return (T)(object)RandomString();
            }
            return default(T);
        }

        public T Convert()
        {
            throw new NotImplementedException();
        }
    }
}
