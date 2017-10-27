using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumerableDemos;

namespace Console
{
    public class Program
    {
        public static void Main (string[] args)
        {
            string sentence = "The quick brown fox jumps over the lazy dog";// scrabble a it man dude wowser obnoxious";

            // Split the string into individual words to create a collection. 
            string[] words = sentence.Split(' ');

            // Using query expression syntax. 
            var query = from word in words
                group word.ToUpper() by word.Length into gr
                orderby gr.Key
                select new { Length = gr.Key, Words = gr };

            //You can also write above query by using method-based query syntax. 
            var query1 = words.
                GroupBy(w => w.Length, w => w.ToUpper()).
                Select(g => new { Length = g.Key, Words = g }).
                OrderBy(o => o.Length);

            //use either query or query1 variable to get result
            foreach (var obj in query)
            {
                System.Console.WriteLine("\n Word length {0}:", obj.Length);
                foreach (string word in obj.Words)
                    System.Console.WriteLine(word);
            }



            MyList<Default.Customer> customers = new MyList<Default.Customer>();
            Default.Customer cust = new Default.Customer {
                Name = "Jason Romero",
                City = "Jacksonville",
                Mobile = 7272600629,
                Amount = 8000.00
            };
            
            customers.Add(cust);

            //foreach (var customer in customers)
            //{
            //    System.Console.WriteLine(cust.Name);
            //    System.Console.WriteLine(cust.City);
            //    System.Console.WriteLine(cust.Mobile);
            //    System.Console.WriteLine(cust.Amount.ToString("c"));
            //}


            // Using some abstraction with generics
            ListOfStrings list = new ListOfStrings();
            List<Default.Customer> custList = new List<Default.Customer>();
            list.GetListOfStrings(customers);

            System.Console.ReadKey();
            //System.Console.ReadLine();

        }
    }
}
