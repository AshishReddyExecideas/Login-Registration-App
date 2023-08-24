//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ACM.BL1
//{
//    internal class Product
//    {
//    }
//}



using ACM.BL1;
using Lacon.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }

        private string productName;
        public string ProductName
        {
            get
            {
                return StringHandler.InsertSpaces(productName);
            }
        }

        public Product Retrieve(int productId)
        {


            return new Product();
        }

        public bool Save()
        {
            return true;
        }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString() => ProductName;

        public string Log() => $"{ProductDescription} and {ProductName} ";

    }
}