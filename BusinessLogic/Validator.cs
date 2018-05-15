using BusinessEnitity.Models;
using DataLogic;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class Validator
    {
        public bool IsValid()
        {
            DataAssignment dataAssignment = new DataAssignment();
            List<Product> products = dataAssignment.ProductAssign();
            List<Size> sizes = dataAssignment.SizeAssign();
            foreach (var k in products)
            {
               var result=sizes.Contains(k.ProductId);
               
            }
            return true;
        }
    }
}
