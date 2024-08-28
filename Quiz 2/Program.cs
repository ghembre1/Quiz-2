using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Quiz_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the item price:");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the sales tax:");
            double tax = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter promotional discount");
            double discount = Convert.ToDouble(Console.ReadLine());

            double Cost = (price * tax)  + (price * discount);
            Console.Write("The total cost for the item is ");
            Console.Write(Cost);

            Console.ReadLine();
        }
    }
}
