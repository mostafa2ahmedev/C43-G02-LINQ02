
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

            #region LINQ – Transformation Operators
            //1. Return a sequence of just the names of a list of products.
            //var productNames = ProductList
            //    .Select(p => p.ProductName)
            //    .ToList();

            ////2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] wordss = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var transformedWords = wordss
            //    .Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() })
            //    .ToList();
            ////3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var productSummary = ProductList
            //     .Select(p => new { p.ProductName, Price = p.UnitPrice, p.UnitsInStock })
            //    .ToList();
            ////4. Determine if the value of int in an array matches its position in the array.

            //int[] Arrr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var indexMatch = Arrr
            //    .Select((num, index) => new { Index = index, Number = num, Match = num == index })
            //    .ToList();
            ////5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var numberPairs = from a in numbersA
            //                  from b in numbersB
            //                  where a < b
            //                  select new { A = a, B = b };
            ////6. Select all orders where the order total is less than 500.00.
            //var smallOrders = CustomerList
            //    .SelectMany(c => c.Orders)
            //    .Where(o => o.Total < 500)
            //     .ToList();

            ////7. Select all orders where the order was made in 1998 or later.
            //var recentOrders = CustomerList
            //    .SelectMany(c => c.Orders)
            //    .Where(o => o.OrderDate.Year >= 1998)
            //    .ToList();

            #endregion

            #region LINQ - Set Operators
            //1. Find the unique Category names from the Product List
            //var uniqueCategories = ProductList
            //      .Select(p => p.Category)
            //      .Distinct()
            //      .ToList();
            ////2. Produce a sequence containing the unique first letter from both product and customer names.

            //var uniqueFirstLetters = ProductList
            //          .Select(p => p.ProductName[0])
            //          .Union(CustomerList.Select(c => c.CustomerName[0]))
            //          .Distinct()
            //          .ToList();
            ////3. Create one sequence that contains the common first letter from both product and customer names.
            //var commonFirstLetters = ProductList
            //          .Select(p => p.ProductName[0])
            //          .Intersect(CustomerList.Select(c => c.CustomerName[0]))
            //          .ToList();
            ////4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var uniqueProductFirstLetters = ProductList
            //          .Select(p => p.ProductName[0])
            //          .Except(CustomerList.Select(c => c.CustomerName[0]))
            //          .ToList();
            ////5. Create one sequence that contains the last three characters in each name of all customers and products, including any duplicates.
            //var lastThreeChars = ProductList
            //          .Select(p => p.ProductName.Length >= 3 ? p.ProductName[^3..] : p.ProductName)
            //          .Concat(CustomerList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName[^3..] : c.CustomerName))
            //          .ToList();


            #endregion

            #region LINQ - Quantifiers
            //  1.Determine if any of the words in dictionary_english.txt contain the substring 'ei'.
            //var words = File.ReadAllLines("dictionary_english.txt");

            //bool containsEi = words.Any(w => w.Contains("ei"));
            ////2. Return a grouped list of products only for categories that have at least one product that is out of stock.
            //var categoriesWithOutOfStock = ProductList
            //           .Where(p => p.UnitsInStock == 0)
            //           .GroupBy(p => p.Category)
            //           .ToList();
            ////3. Return a grouped list of products only for categories that have all of their products in stock.

            //4.var categoriesFullyStocked = ProductList
            //          .GroupBy(p => p.Category)
            //          .Where(g => g.All(p => p.UnitsInStock > 0))
            //          .ToList();

            #endregion

            #region LINQ – Grouping Operators
            ////1. Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var groupedByRemainder = numbers
            //    .GroupBy(n => n % 5)
            //    .ToList();


            ////2. Use group by to partition a list of words by their first letter (using dictionary_english.txt).
            //var wwords = File.ReadAllLines("dictionary_english.txt");

            //var groupedByFirstLetter = wwords
            //    .GroupBy(w => w[0])
            //    .ToList();
            ////3. Group words that consist of the same characters together.
            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            //var groupedByAnagram = Arr
            //    .GroupBy(w => string.Concat(w.OrderBy(c => c)))
            //    .ToList();

            #endregion

        }
    }
}
