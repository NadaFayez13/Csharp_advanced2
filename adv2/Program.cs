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

            #region q8
            //What is the 'class' constraint? Write an example.
            //It limits the type parameter to reference types, such as classes, interfaces, and arrays and Value types like structs and enums are not allowed

            //    public class Repository<T> where T : class
            //{
            //    public T Item { get; set; }
            //}
            #endregion

            #region q9
            //What is the 'new()' constraint? Write an example.
            //the `new()` constraint ensures that the type has a public parameterless constructor, allowing us to create instances of `T` using `new T()`.

            //    public class Factory<T> where T : new()
            //{
            //    public T Create()
            //    {
            //        return new T();
            //    }
            //}

            #endregion

            #region q10
            // What is the interface constraint? Write an example.
            //  interface constraint requires that the type implements the specified interface (directly or indirectly).

            //    public interface IPrintable
            //{
            //    void Print();
            //}

            //public class Printer<T> where T : IPrintable
            //{
            //    public void PrintItem(T item)
            //    {
            //        item.Print();
            //    }
            //}
            #endregion

            #region q11
            //What is the base class constraint? Write an example.
            //base class constraint specifies that  type parameter must inherit from specified base class , it can be the base class itself or any class derived from itt

            //    public class BaseClass
            //{
            //    // Base class members
            //}

            //public class Service<T> where T : BaseClass
            //{
            //    // T must inherit from BaseClass
            //}
            #endregion

            #region q12
            //How do you apply multiple constraints? Write an example. 
            //You can apply multiple constraints to a type parameter by separating them with commas after `where`.
            //The order matters: specify the base class first, followed by any interfaces, and place `new()` last if needed.


        //    public interface IAuditable
        //{
        //    void Audit();
        //}

        //public class BaseEntity
        //{
        //    public int Id { get; set; }
        //}

        //public class Repository<T> where T : BaseEntity, IAuditable, new()
        //{
        //    public T Create()
        //    {
        //        return new T();
        //    }
        //}
            #endregion
    }
    }
}
