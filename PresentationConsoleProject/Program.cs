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
            Validator validator = new Validator();
            validator.IsValid();
            Console.ReadKey();
        }
    }
}
