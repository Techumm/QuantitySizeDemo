using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            Validator validator = new Validator();
            for (int i = 1; i <= 3; i++)
            {
                result=validator.IsValid(i);
                if(result)
                    Console.WriteLine("Match for product id ",i);
                else
                    Console.WriteLine("Missmatch for product id ",i);
            }
            Console.ReadKey();
        }
    }
}
