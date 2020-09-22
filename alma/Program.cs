using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alma
{
    class Program
    {
        static void Main(string[] args)
        {
            int db = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            for (int i=0;i<db;i++)
            {
                Console.Write("{0},",a);
                int cs = a;
                a = b;
                b = cs + b;


            }
            Console.ReadLine();
        }
    }
}
