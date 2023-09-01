using Acme.Common;
using static Acme.Common.LoggingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory.
    /// </summary>
    public class Product
    {
        #region Constructors
        public Product()
        {
            var coloroptions = new string[4];
            coloroptions[0] = "Black";
            coloroptions[1] = "Orange";
            coloroptions[2] = "Yellow";
            coloroptions[3] = "Purple";
            Console.Writeline(coloroptions);

            string[] colouroptions1 = { "Black", "Orange", "Yellow", "Purple" };
            Console.Writeline(coloroptions1);

            for (int i = 0; i < colouroptions1.length; i++)
            {
                colouroptions1[i] = colouroptions1[i].ToLower();
            }

            foreach (var color in colouroptions1)
            {
                Console.Writeline("Thw color is {color}");
            }

            var yellowIndex = Array.IndexOf(colouroptions1, Yellow);

            colouroptions1.SetValue("Blue",3); 
        }
        public Product(int productId,
                        string productName,
                        string description) : this()
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Description = description;
        }
        #endregion

        #region Properties
        public DateTime? AvailabilityDate { get; set; }

        public decimal Cost { get; set; }

        public string Description { get; set; }

        public int ProductId { get; set; }

        private string productName;
        public string ProductName
        {
            get {
                var formattedValue = productName?.Trim();
                return formattedValue;
            }
            set
            {
                if (value.Length < 3)
                {
                    ValidationMessage = "Product Name must be at least 3 characters";
                }
                else if (value.Length > 20)
                {
                    ValidationMessage = "Product Name cannot be more than 20 characters";

                }
                else
                {
                    productName = value;

                }
            }
        }

        private Vendor productVendor;
        public Vendor ProductVendor
        {
            get {
                if (productVendor == null)
                {
                    productVendor = new Vendor();
                }
                return productVendor;
            }
            set { productVendor = value; }
        }

        public string ValidationMessage { get; private set; }

        #endregion

        /// <summary>
        /// Calculates the suggested retail price
        /// </summary>
        /// <param name="markupPercent">Percent used to mark up the cost.</param>
        /// <returns></returns>
        public decimal CalculateSuggestedPrice(decimal markupPercent) =>
             this.Cost + (this.Cost * markupPercent / 100);

        public override string ToString()
        {
            return this.ProductName + " (" + this.ProductId + ")";
        }
    }
}
