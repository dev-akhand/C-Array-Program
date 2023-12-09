using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] array = new object[3];
            array[0] = 1;
            array[1] = "APS";
            Customer c = new Customer();
            c.ID = 99;
            c.Name = "LAMBERDAR";
            array[2] = c;
            foreach (object  item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        
    }
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
