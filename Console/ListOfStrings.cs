using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumerableDemos;

namespace Console
{
    public class ListOfStrings
    {

        public void GetListOfStrings<T>(MyList<T> list)
        {
            List<Default.Employee> employees = new List<Default.Employee>();
            Default.Employee emp1 = new Default.Employee { Name = "Jason", Skills = new List<string> { "C", "C++", "Java" } };
            Default.Employee emp2 = new Default.Employee { Name = "Bill", Skills = new List<string> { "SQL Server", "C#", "ASP.NET" } };
            Default.Employee emp3 = new Default.Employee { Name = "George", Skills = new List<string> { "C#", "ASP.NET MVC", "Windows Azure", "SQL Server" } };

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            // Query using Select()
            IEnumerable<List<String>> resultSelect = employees.Select(e=> e.Skills);
            IEnumerable<String> names = employees.Select(n => n.Name);

            //IEnumerable<List<List<String>>>[,] combo = new List<resultSelect>, <List<names>;


            System.Console.WriteLine("**************** Select ******************");

            // Two foreach loops are required to iterate through the results
            // because the query returns a collection of arrays.
            if (resultSelect != null)
            {
                foreach (List<String> skillList in resultSelect)
                {
                    foreach (string skill in skillList)
                    {
                        System.Console.WriteLine(skill);
                    }
                    System.Console.WriteLine();
                }

            }

            

            // Query using SelectMany()
            //IEnumerable<string> resultSelectMany = employees.SelectMany(emp => emp.Skills);

            //System.Console.WriteLine("**************** SelectMany ******************");

            // Only one foreach loop is required to iterate through the results 
            // since query returns a one-dimensional collection.
            //foreach (string skill in resultSelectMany)
            //{
            //    System.Console.WriteLine(skill);
            //}

            System.Console.WriteLine("-----------------------------------------------------------------------");
        }


    }
}
