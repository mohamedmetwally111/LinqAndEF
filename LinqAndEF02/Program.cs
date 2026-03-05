using day10_G01;
using static day10_G01.ListGenerators;
namespace LINQAndEF02
{
    internal class Program
    {
        static void Main()
        {
            #region LINQ - Restriction Operators 
            //var res01 = ProductList.Where((p) => p.UnitsInStock == 0);
            //foreach (var res0 in res01)
            //    Console.WriteLine(res0);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            //var res02 = ProductList.Where((p) => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);
            //foreach (var res1 in res02)
            //    Console.WriteLine(res1);

            //Console.WriteLine("-------------------------------------------------------------------------------------------------------");

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
            //                "nine" };

            //var res03 = Arr.Select((name, index) => new { name, index })
            //               .Where((x) => x.name.Length < x.index)
            //               .Select((x) => x.index);

            //foreach (var res2 in res03)
            //    Console.WriteLine(res2); 
            #endregion

            #region LINQ - Element Operators
            //var res01= ProductList.First((p) => p.UnitsInStock==0);
            // Console.WriteLine(res01);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            // var res02 = ProductList.FirstOrDefault((p) => p.UnitPrice > 1000);
            // Console.WriteLine(res02);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // var res03 = Arr.Where((n) => n > 5)
            //     .Skip(1)
            //     .First();
            // Console.WriteLine (res03); 
            #endregion

            #region LINQ - Aggregate Operators 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res01 = Arr.Count((n) => n % 2 == 1);
            //Console.WriteLine(res01);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            //var res02=CustomerList.SelectMany((c) => c.Orders);
            //foreach(var res in res02)
            //    Console.WriteLine(res);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            //var res03 = ProductList.GroupBy((P) => P.Category)
            //                       .Select((p) => new
            //                       {
            //                             category=p.Key,
            //                             productCount=p.Count()
            //                       });


            //foreach(var res in res03)
            //    Console.WriteLine(res.category+"-"+res.productCount);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            //int[] Arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int sum = Arr.Sum();
            //Console.WriteLine(sum);

            ////Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            ////string[] words = File.ReadAllLines("dictionary_english.txt");

            ////int totalCharacters = words.Sum(word => word.Length);
            ////Console.WriteLine(totalCharacters);

            // Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            // var res04=ProductList.GroupBy((p) => p.Category)
            //            .Select((p) => new
            //            {
            //                Category=p.Key,
            //                TotalUnit=p.Sum((g)=>g.UnitsInStock)
            //            });
            // foreach (var res in res04)
            //     Console.WriteLine(res.Category+' '+res.TotalUnit);

            // Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            // var res05=from p in ProductList
            //           group p by p.Category into g
            //           let minprice=g.Min((x)=>x.UnitPrice)
            //           from prod in g
            //           where prod.UnitPrice == minprice
            //           select new
            //           {
            //               Category = g.Key,
            //               ProductName = prod.ProductName,
            //               UnitPrice = prod.UnitPrice
            //           };

            // foreach (var item in res05)
            // {
            //     Console.WriteLine($"{item.Category} - {item.ProductName} : {item.UnitPrice:C}");
            // }

            //var res06= ProductList.GroupBy((p) => p.Category)
            //            .Select((g) => new
            //            {
            //                category=g.Key,
            //                maxPrice=g.Max((p)=>p.UnitPrice)
            //            });
            // foreach (var res in res06)
            //     Console.WriteLine($"{res.category}-{res.maxPrice}");

            // Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            //var res07= ProductList.GroupBy((p) => p.Category)
            //            .SelectMany((g) =>
            //            {

            //                var maxprice = g.Max((x) => x.UnitPrice);
            //                return g.Where(p => p.UnitPrice == maxprice)

            //                .Select(p => new
            //                {
            //                    Category = g.Key,
            //                    ProductName = p.ProductName,
            //                    UnitPrice = p.UnitPrice
            //                });
            //            });

            // foreach (var res in res07)
            //     Console.WriteLine(res);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            //var res08=ProductList.GroupBy((p) => p.Category)
            //           .Select((g) => new
            //           {
            //               Category=g.Key,
            //               AvargePrice=g.Average((x)=>x.UnitPrice)
            //           });

            //foreach (var res in res08)
            //    Console.WriteLine(res); 
            #endregion

            #region LINQ - Ordering Operators 
            //var res01=ProductList.OrderBy((p) => p.ProductName);
            //foreach(var res in res01)
            //    Console.WriteLine(res.ProductName);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");


            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var res02 = Arr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var res in res02)
            //    Console.WriteLine(res);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            //var res03=ProductList.OrderByDescending((p)=>p.UnitsInStock);
            //foreach (var res in res03)
            //    Console.WriteLine(res);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            //string[] Arr2 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
            //                 "nine" };
            //var res04=Arr2.OrderBy((p) => p.Length)
            //    .ThenBy(w => w);

            //foreach(var res in res04)
            //    Console.WriteLine(res);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");


            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var res05=words.OrderBy((p)=>p.Length)
            //    .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach(var res in res05)
            //    Console.WriteLine(res);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");


            //string[] Arr3 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var res06 = Arr3.OrderBy((p) => p.Length)
            //              .ThenByDescending((w) => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var res in res06)
            //    Console.WriteLine(res);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            //string[] Arr4 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
            //                 "nine" };
            //var res07 = Arr4.Where((p) => p[1] == 'i')
            //               .Reverse();

            //foreach (var res in res07)
            //    Console.WriteLine(res);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            #endregion

            #region LINQ – Transformation Operators 
            //var res01 = ProductList.Select((p) => p.ProductName);
            //foreach (var res in res01)
            //    Console.WriteLine(res);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var res02 = words.Select((P) => new
            //{
            //    uppercase = P.ToUpper(),
            //    lowercase = P.ToLower()
            //});
            //foreach (var res in res02)
            //    Console.WriteLine(res);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            //var res03 = ProductList.Select((p) => new
            //{
            //    Price = p.UnitPrice

            //});
            //foreach (var res in res03)
            //    Console.WriteLine(res.Price);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res04 = Arr.Where((p, i) => p == i);
            //foreach (var res in res04)
            //    Console.WriteLine(res);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var res05=from nA in numbersA
            //           from nB in numbersB
            //           where nA<nB
            //           select new {A=nA, B=nB};

            //foreach (var res in res05)
            //    Console.WriteLine(res);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            //var res06 = CustomerList.SelectMany((p) => p.Orders)
            //                       .Where((o) => o.Total < 500.00);

            //foreach (var res in res06)
            //    Console.WriteLine(res);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            //var stertDate = new DateTime(1998, 1, 1);
            //var res07 = CustomerList.SelectMany((p) => p.Orders)
            //                      .Where((o) => o.OrderDate > stertDate);

            //foreach (var res in res07)
            //    Console.WriteLine(res);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            #endregion

            #region LINQ - Partitioning Operators 
            //var res01= CustomerList.Where((P) => P.City == "Washington")
            //              .SelectMany((x) => x.Orders)
            //              .Take(3);
            // foreach (var res in res01)
            //     Console.WriteLine(res);

            // Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            // var res02 = CustomerList.Where((P) => P.City == "Washington")
            //              .SelectMany((x) => x.Orders)
            //              .Take(2);
            // foreach (var res in res02)
            //     Console.WriteLine(res);

            // Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // var res03 =numbers.Where((p, i) => p < i);
            // foreach (var res in res03)
            //     Console.WriteLine(res);

            // Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            // int[] numbers1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // var res04 = numbers1.SkipWhile((p) => p % 3!=0);

            // foreach (var res in res04)
            //     Console.WriteLine(res);

            // Console.WriteLine("-----------------------------------------------------------------------------------------------------");


            // int[] numbers2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // var res05 = numbers2
            //     .SkipWhile((num, index) => num >= index);

            // foreach (var res in res05)
            //     Console.WriteLine(res); 
            #endregion

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //bool res01 = words.Any(word => word.Contains("ei"));

            //Console.WriteLine(res01);

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------");


            var res02 = ProductList.GroupBy(p => p.Category)
                                    .Where(g => g.Any(p => p.UnitsInStock==0)) 
                                    .Select(g => new
                                     {
                                         Category = g.Key, 
                                         products = g.ToList() 
                                      });

            foreach (var res in res02)
            {
                Console.WriteLine($"Category: {res.Category}");
                foreach (var prod in res.products)
                    Console.WriteLine($"  {prod.ProductName} - UnitsInStock: {prod.UnitsInStock}");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            var res03 = ProductList.GroupBy(p => p.Category)
                                   .Where(g => g.All(p => p.UnitsInStock > 0))
                                   .Select(g => new
                                   {
                                       Category = g.Key,
                                       products = g.ToList()
                                   });

            foreach (var res in res03)
            {
                Console.WriteLine($"Category: {res.Category}");
                foreach (var prod in res.products)
                    Console.WriteLine($"  {prod.ProductName} - UnitsInStock: {prod.UnitsInStock}");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");

        }
    }
}
