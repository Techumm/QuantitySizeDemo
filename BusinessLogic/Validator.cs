using BusinessEnitity.Models;
using DataLogic;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class Validator
    {
        public bool IsValid(int id)
        {
            DataAssignment dataAssignment = new DataAssignment();
            List<Product> products = dataAssignment.ProductAssign();
            List<Size> sizes = dataAssignment.SizeAssign();
            var SizeQuantity = sizes.Where(s => s.ProductId == id).Select(s => s.Quantity).Sum();
            var ProductQuantity = products.Where(s => s.ProductId == id).Select(s => s.Quantity).FirstOrDefault();

            if (SizeQuantity == ProductQuantity)
                return true;
            else
                return false;
        }
    }
}
