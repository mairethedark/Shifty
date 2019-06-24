using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifty
{
    class Program
    {
        static void Main(string[] args)
        {
            int stuff = 0;
            int usernum;
            Console.WriteLine("Enter a Number");
            usernum = int.Parse(Console.ReadLine());


            while(usernum != 0)

                {

                usernum = usernum >> 1;
                ++stuff;
                }



            Console.WriteLine(usernum);
            Console.WriteLine(stuff);



            Console.Read();
        }
    }
}
