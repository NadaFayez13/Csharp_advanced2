using System.Data;

namespace adv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q4
            // What is a generic method? 
            //generic method uses type parameters like `<T>` to work with different data types while checking type safety at compile time.

            //int a = 13, b = 11;
            //methods.Swap(ref a, ref b);
            //Console.WriteLine($"a = {a}, b = {b}");

            #endregion

            #region q5
            //int maxInt = methods.Max(11, 13);
            //Console.WriteLine($"Max Int: {maxInt}");
            #endregion

            #region q6
            // What is a generic interface?
            //generic interface uses type parameters like <T>, allowing classes to work with different data types while keeping the code type-safe and reusable.
            #endregion

            #region q7
            //What is the 'struct' constraint? Write an example.
            //It limits the type parameter to value types like `int`, `bool`, `double`, and `struct`. Nullable value types are allowed, but reference types are not.

            //    public class Container<T> where T : struct
            //{
            //    public T Value { get; set; }
            //}

            #endregion

            
        }
    }
}
