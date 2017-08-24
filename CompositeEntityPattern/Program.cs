using CompositeEntityPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEntityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.SetData("Test", "Data");
            client.PrintData();
            client.SetData("Second test", "Data1");
            client.PrintData();

            Console.ReadLine();
        }
    }
}
