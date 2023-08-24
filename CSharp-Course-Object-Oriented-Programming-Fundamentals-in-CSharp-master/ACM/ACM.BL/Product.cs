using Lacon.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase,ILoggable
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

        /// <summary>
        /// Retrieve one product.
        /// </summary>
        public Product Retrieve(int productId)
        {
            // Code that retrieves the defined product

            return new Product();
        }

        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined product

            return true;
        }

        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString() => ProductName;

        public string Log() =>$"{ProductDescription} and {ProductName} ";

    }
}
