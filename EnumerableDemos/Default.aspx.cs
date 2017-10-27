using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnumerableDemos
{
    public partial class Default : System.Web.UI.Page
    {
        protected static void Page_Load (object sender, EventArgs e)
        {
           


        }


        // Let us first see how we can enumerate an custom MyList<t> class implementing IEnumerable<T>


        protected void Button1_Click (object sender, EventArgs e)
        {
            foreach (var cust in GetAllCustomer())
            {
                Response.Write("Name: " + cust.Name + "<br> " + "City: " + cust.City + " <br> "
                               + "Mobile " + cust.Mobile + "<br> " + "Amount :" + cust.Amount.ToString("c") + "<br>" + "-----" + "<br>");
            }
            List<Employee> employees = new List<Employee>();
            Employee emp1 = new Employee { Name = "Jason", Skills = new List<string> { "C", "C++", "Java" } };
            Employee emp2 = new Employee { Name = "Bill", Skills = new List<string> { "SQL Server", "C#", "ASP.NET" } };

            Employee emp3 = new Employee { Name = "George", Skills = new List<string> { "C#", "ASP.NET MVC", "Windows Azure", "SQL Server" } };

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            // Query using Select()
            //IEnumerable<List<String>> resultSelect = employees.Select(e=> e.Skills);

           // Console.WriteLine("**************** Select ******************");

            // Two foreach loops are required to iterate through the results
            // because the query returns a collection of arrays.
           // foreach (List<String> skillList in resultSelect)
            //{
            //    foreach (string skill in skillList)
            //    {
            //        Response.Write(skill);
            //    }
            //    Console.WriteLine();
            //}

            // Query using SelectMany()
            IEnumerable<string> resultSelectMany = employees.SelectMany(emp => emp.Skills);

            Response.Write("**************** SelectMany ******************");

            // Only one foreach loop is required to iterate through the results 
            // since query returns a one-dimensional collection.
            foreach (string skill in resultSelectMany)
            {
                Response.Write(skill);
            }

            // Console.ReadKey();
        }

        public class Employee
        {
            public string Name { get; set; }
            public List<string> Skills { get; set; }
        }

        public class Customer
        {
            private String _Name, _City;
            private long _Mobile;
            private double _Amount;

            public String Name
            {
                get { return _Name; }
                set { _Name = value; }
            }

            public String City
            {
                get { return _City; }
                set { _City = value; }
            }

            public long Mobile
            {
                get { return _Mobile; }
                set { _Mobile = value; }
            }


            public double Amount
            {
                get { return _Amount; }
                set { _Amount = value; }
            }


        }

        Customer[] customers = new Customer[]
        {

            new Customer {Name="Vithal Wadje",City="Mumbai",Mobile=7272600629,Amount=89.45 },
            new Customer { Name = "Sudhir Wadje", City = "Latur", Mobile = 7272600629, Amount =426.00 },
            new Customer { Name = "Anil", City = "Delhi", Mobile = 7272600629, Amount = 5896.20 }
        };

        public IEnumerable<Customer> GetAllCustomer ()
        {
            return customers;
        }

    }
}