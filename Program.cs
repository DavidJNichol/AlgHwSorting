using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq;

namespace EnglishWordsAlgorithmAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rows = File.ReadAllLines(@"C:\Users\David Nichol\Desktop\WordsFile.txt").ToList();

            var sortByReverse = from file in rows
                                orderby file descending
                                select file;



            foreach (string value in sortByReverse)
            {
                Console.WriteLine(value);
            }

            var time = new System.Diagnostics.Stopwatch();
            time.Start();
            time.Stop();
            Console.WriteLine($"Execution Time: {time.ElapsedMilliseconds} ms");
            Console.ReadKey();

        }
    }
}

            //// Words With Z
            //var startsWith1 = "Z";
            //var startsWith2 = "z";
            //var time = new System.Diagnostics.Stopwatch();
            //time.Start();

            //var queryResults =
            //    from r in rows
            //    where r.StartsWith(startsWith1, StringComparison.Ordinal) || r.StartsWith(startsWith2, StringComparison.Ordinal)
            //    select r;

            //foreach (var item in queryResults)
            //{
            //    Console.WriteLine(item);
            //}

            //time.Stop();

            //Console.WriteLine($"Execution Time: {time.ElapsedMilliseconds} ms");
            //Console.ReadKey();




//            //ReturnsWordsWithHeAtBeggining

//            var startsWith3 = "HE";
//            var startsWith1 = "he";
//            var startsWith2 = "hE";           
//            var startsWith4 = "He";

//            var time = new System.Diagnostics.Stopwatch();
//            time.Start();


//            var queryResults =
//                from r in rows
//                where r.StartsWith(startsWith1, StringComparison.Ordinal) || r.StartsWith(startsWith2, StringComparison.Ordinal) || r.StartsWith(startsWith3, StringComparison.Ordinal) || r.StartsWith(startsWith4, StringComparison.Ordinal)
//                select r;




//            foreach (var item in queryResults)
//            {
//                Console.WriteLine(item);
//            }

//            time.Stop();


//            Console.WriteLine($"Execution Time: {time.ElapsedMilliseconds} ms");
//            Console.ReadKey();




//            // Words With E In Second Position

//            var time = new System.Diagnostics.Stopwatch();
//            time.Start();

//            var result = rows.Where(e => e.Length > 1 && e[1] == 'e');
//            var result2 = rows.Where(E => E.Length > 1 && E[1] == 'E');

//            foreach (var item in result)
//            {
//                Console.WriteLine(item);
//            }

//            foreach (var item in result2)
//            {
//                Console.WriteLine(item);
//            }

//            time.Stop();

//            Console.WriteLine($"Execution Time: {time.ElapsedMilliseconds} ms");
//            Console.ReadKey();










//        }
//    }
//}
