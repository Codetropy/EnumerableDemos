using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumerableDemos;

namespace Console
{
    public class SingleOrDefault
    {
        public void GetSingleOrDefault<T>(MyList<T> list)
        {

            List<int> data = new List<int> {10, 20, 30, 40, 50};

            int writer;// = "";
            //Try to get element at specified position
            //Console.WriteLine(data.ElementAt(1)); //result:20
            writer = data.ElementAt(1);

            //Try to get element at specified position if exist, else returns default value
            //Console.WriteLine(data.ElementAtOrDefault(10)); //result:0, since default value is 0 
            data.ElementAtOrDefault(10);

            //Console.WriteLine(data.First()); //result:10 
            data.First();
            //Console.WriteLine(data.Last()); //result:50
            data.Last();

            //try to get first element from matching elements collection
            //Console.WriteLine(data.First(d => d <= 20)); //result:10 
            data.SingleOrDefault(d => d <= 20);

            //try to get first element from matching elements collection else returns default value
            //Console.WriteLine(data.SingleOrDefault(d => d >= 100)); //result:0, since default value is 0 
            data.SingleOrDefault(d => d >= 100);

            //Try to get single element 
            // data.Single(); //Exception:Sequence contains more than one element 
            data.SingleOrDefault();

            //Try to get single element if exist otherwise returns default value
            // data.SingleOrDefault(); //Exception:Sequence contains more than one element 
            data.SingleOrDefault();

            //try to get single element 10 if exist
            //Console.WriteLine(data.Single(d => d == 10)); //result:10 
            data.Single(d => d == 10);

            //try to get single element 100 if exist otherwise returns default value
            //Console.WriteLine(data.SingleOrDefault(d => d == 100)); //result:0, since default value is 0
            data.SingleOrDefault(d => d == 100);

            System.Console.WriteLine();
        }



    }
}
