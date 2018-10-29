using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products being held in inventory.
    /// </summary>
    public class Product
    {
        #region Constructors

        public Product()
        {
            Console.WriteLine("A new instance of 'Product' class has been created.");
        }

        public Product(int productId, 
                        string productName, 
                        string description)
        {
            this.ProductID = productId;
            this.ProductName = productName;
            this.Description = description;
        }

        #endregion

        #region Properties
        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private int productId;

        public int ProductID
        {
            get { return productId; }
            set { productId = value; }
        }
        #endregion

        #region Methods

        public string SayHello()
        {
            var vendor = new Vendor();
            vendor.SendWelcomeEmail("Welcome email from product");

            var emailService = new EmailService();
            string confirmation = emailService.SendMessage("New Product", this.ProductName, "test@test.net");

            string resultLog = Common.LoggingService.LogAction("Hello from the new product"); 

            return $"Hello {productName} ({productId}): {description}"; 
        }
        #endregion
    }
}
