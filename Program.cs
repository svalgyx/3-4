using System;
using HW3_4.Interfaces;
using HW3_4.Implementings;
using System.Diagnostics.SymbolStore;

namespace HW3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter[] arrays = new IPrinter[10];
            Random rnd = new Random();
            for (int i = 0; i < arrays.Length; i++)
            {
                int type_num = rnd.Next(1, 5);
                if (type_num == 1)
                {
                    int num = rnd.Next(0, 3);
                    if (num == 0)
                    {
                        Single<int> single_array = new Single<int>("y", rnd.Next(1, 11));
                        single_array.Create();
                        arrays[i] = single_array;
                    }
                    if (num == 1)
                    {
                        int rows = rnd.Next(1, 11);
                        int columns = rnd.Next(1, 11);
                        Matrix<int> matrix_array = new Matrix<int>("y", rows, columns);
                        matrix_array.Create();
                        arrays[i] = matrix_array;
                    }
                    if (num == 2)
                    {
                        int jagged_rows = rnd.Next(1, 11);
                        Jagged<int> jagged_array = new Jagged<int>("y", jagged_rows);
                        jagged_array.Create();
                        arrays[i] = jagged_array;
                    }
                }
                if (type_num == 2)
                {
                    int num = rnd.Next(0, 3);
                    if (num == 0)
                    {
                        Single<double> single_array = new Single<double>("y", rnd.Next(1, 11));
                        single_array.Create();
                        arrays[i] = single_array;
                    }
                    if (num == 1)
                    {
                        int rows = rnd.Next(1, 11);
                        int columns = rnd.Next(1, 11);
                        Matrix<double> matrix_array = new Matrix<double>("y", rows, columns);
                        matrix_array.Create();
                        arrays[i] = matrix_array;
                    }
                    if (num == 2)
                    {
                        int jagged_rows = rnd.Next(1, 11);
                        Jagged<double> jagged_array = new Jagged<double>("y", jagged_rows);
                        jagged_array.Create();
                        arrays[i] = jagged_array;
                    }
                }
                if (type_num == 3)
                {
                    int num = rnd.Next(0, 3);
                    if (num == 0)
                    {
                        Single<bool> single_array = new Single<bool>("y", rnd.Next(1, 11));
                        single_array.Create();
                        arrays[i] = single_array;
                    }
                    if (num == 1)
                    {
                        int rows = rnd.Next(1, 11);
                        int columns = rnd.Next(1, 11);
                        Matrix<bool> matrix_array = new Matrix<bool>("y", rows, columns);
                        matrix_array.Create();
                        arrays[i] = matrix_array;
                    }
                    if (num == 2)
                    {
                        int jagged_rows = rnd.Next(1, 11);
                        Jagged<bool> jagged_array = new Jagged<bool>("y", jagged_rows);
                        jagged_array.Create();
                        arrays[i] = jagged_array;
                    }
                }
                if (type_num == 4)
                {
                    int num = rnd.Next(0, 3);
                    if (num == 0)
                    {
                        Single<string> single_array = new Single<string>("y", rnd.Next(1, 11));
                        single_array.Create();
                        arrays[i] = single_array;
                    }
                    if (num == 1)
                    {
                        int rows = rnd.Next(1, 11);
                        int columns = rnd.Next(1, 11);
                        Matrix<string> matrix_array = new Matrix<string>("y", rows, columns);
                        matrix_array.Create();
                        arrays[i] = matrix_array;
                    }
                    if (num == 2)
                    {
                        int jagged_rows = rnd.Next(1, 11);
                        Jagged<string> jagged_array = new Jagged<string>("y", jagged_rows);
                        jagged_array.Create();
                        arrays[i] = jagged_array;
                    }
                }
            }
            for (int i = 0; i < arrays.Length; i++)
            {
                arrays[i].Print();

            }
            Console.Write("Press enter to exit: ");
            Console.ReadLine();
        }
    }
}
