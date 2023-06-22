using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBasic
{
     class Program:Demo,Interface_One,Interface_Two
    {
        static void Main(string[] args)
        {
            Interface_One interface_One =new Program();
            interface_One.One();
            Interface_Two interface_Two =new Program();
            interface_Two.Two();
            Interface_One interface_Th =new InterfacesTwo();
            interface_Th.One();
            


            Console.ReadLine();
        }

        public void One()
        {
            Console.WriteLine("Ruchita");
        }

        public void Two()
        {
            Console.WriteLine("Chaudhari");
        }
    }
}
