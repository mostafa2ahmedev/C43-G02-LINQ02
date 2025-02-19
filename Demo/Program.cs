
using static Demo.ListGenerators;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators
            //1. Get first Product out of Stock 
            //var result = ProductList.Where(p => p.UnitsInStock == 0).First();
            //Console.WriteLine(result);

            #endregion

            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned

            //var result = ProductList.Where(p => p.UnitPrice>1000).FirstOrDefault();
            //Console.WriteLine(result);

            //3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int secondNumber = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();

            //Console.WriteLine(secondNumber);
        }
    }
}
