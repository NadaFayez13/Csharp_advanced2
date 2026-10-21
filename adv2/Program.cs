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
            int maxInt = methods.Max(11, 13);
            Console.WriteLine($"Max Int: {maxInt}");
            #endregion

        }
    }
}
