
using System;
using System.Security.Cryptography;
using static Demo.ListGenerators;
using static System.Runtime.InteropServices.JavaScript.JSType;
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

            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned

            //var result = ProductList.Where(p => p.UnitPrice>1000).FirstOrDefault();
            //Console.WriteLine(result);

            //3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int secondNumber = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();

            //Console.WriteLine(secondNumber);
            #endregion
            #region LINQ - Aggregate Operators
            //  1.Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result=Arr.Count(c=>c%2==1);

            //Console.WriteLine(result);

            //2. Return a list of customers and how many orders each has.

            //var customerOrders = CustomerList
            //    .Select(c => new
            //    {
            //        c.CustomerID,
            //        c.CustomerName,
            //        OrderCount = c.Orders.Length
            //    })
            //    .ToList();

            //foreach (var item in customerOrders)
            //{
            //    Console.WriteLine(item);
            //}


            //3. Return a list of categories and how many products each has

            //var categoryProducts = ProductList
            //       .GroupBy(p => new { p.Category })
            //       .Select(g => new
            //       {
            //           g.Key.Category,
            //           ProductCount = g.Count()
            //       })
            //       .ToList();
            //foreach (var item in categoryProducts)
            //{
            //    Console.WriteLine(item);
            //}



            //4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count();

            //Console.WriteLine(result);



            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //5. Get the total number of characters in dictionary_english.txt


            //var totalCharacters = words.Sum(word => word.Length);

            //Console.WriteLine(totalCharacters);

            //6.Get the length of the shortest word
            //var shortestLength = words.Min(word => word.Length);
            //Console.WriteLine(shortestLength);
            //7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var longestLength = words.Max(word => word.Length);
            //Console.WriteLine(longestLength);
            //8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var avgLength = words.Average(word => word.Length);
            //Console.WriteLine(avgLength);

            //9. Get the total units in stock for each product category.
            //var totalStockByCategory = ProductList
            //        .GroupBy(p => p.Category)
            //        .Select(g => new
            //        {
            //            Category = g.Key,
            //            TotalUnits = g.Sum(p => p.UnitsInStock)
            //        })
            //                .ToList();
            //foreach (var item in totalStockByCategory)
            //{
            //    Console.WriteLine(item);
            //}

            //10. Get the cheapest price among each category's products

            //var cheapestPriceByCategory = ProductList
            //     .GroupBy(p => p.Category)
            //     .Select(g => new
            //     {
            //         Category = g.Key,
            //         MinPrice = g.Min(p => p.UnitPrice)
            //     })
            //        .ToList();

            //11. Get the products with the cheapest price in each category (Use Let)
            //var cheapestProductsByCategory = ProductList
            //            .GroupBy(p => p.Category)
            //             .Select(g => new
            //                {
            //               Category = g.Key,
            //            CheapestProducts = g.Where(p => p.UnitPrice == g.Min(p2 => p2.UnitPrice)).ToList()
            //            })
            //            .ToList();

            //12. Get the most expensive price among each category's products.

            //        var maxPriceByCategory = ProductList
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    MaxPrice = g.Max(p => p.UnitPrice)
            //})
            // .ToList();

            //13. Get the products with the most expensive price in each category.
            //var mostExpensiveProductsByCategory = ProductList
            //           .GroupBy(p => p.Category)
            //           .Select(g => new
            //           {
            //               Category = g.Key,
            //               MostExpensiveProducts = g.Where(p => p.UnitPrice == g.Max(p2 => p2.UnitPrice)).ToList()
            //           })
            //           .ToList();

            //14. Get the average price of each category's products.

            //var avgPriceByCategory = ProductList
            //      .GroupBy(p => p.Category)
            //      .Select(g => new
            //      {
            //          Category = g.Key,
            //          AvgPrice = g.Average(p => p.UnitPrice)
            //      })
            //      .ToList();




            #endregion


            #region LINQ - Ordering Operators
            //1. Sort a list of products by name
            //var sortedProductsByName = ProductList
            //  .OrderBy(p => p.ProductName)
            //   .ToList();

            ////2. Uses a custom comparer to do a case-insensitive sort of the words in an array
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = Arr
            //    .OrderBy(word => word, StringComparer.OrdinalIgnoreCase)
            //    .ToArray();
            //3. Sort a list of products by units in stock from highest to lowest.
            //var sortedProductsByStock = ProductList
            //  .OrderByDescending(p => p.UnitsInStock)
            //   .ToList();

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.


            //var sortedDigits = Arr
            //    .OrderBy(word => word.Length)
            //    .ThenBy(word => word)
            //    .ToArray();

            //   //5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            //   var sortedWordsByLengthThenAlpha = Arr
            //        .OrderBy(word => word.Length)
            //       .ThenBy(word => word, StringComparer.OrdinalIgnoreCase)
            //        .ToArray();
            //   //6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //   var sortedProductsByCategoryAndPrice = ProductList
            //     .OrderBy(p => p.Category)
            //.ThenByDescending(p => p.UnitPrice)
            //.ToList();
            //   //7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            //   var sortedWordsByLengthThenDescAlpha = Arr
            //      .OrderBy(word => word.Length)
            //       .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase)
            //       .ToArray();
            //   //8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //   var filteredReversedDigits = Arr
            //         .Where(word => word.Length > 1 && word[1] == 'i')
            //        .Reverse()
            //       .ToArray();


            #endregion

          

        }
    }
}
