using System.ComponentModel;

namespace ZackeryKeyInventorySystem
{
    class Product
    {
        #region Private Variables

        // BindingList for the associated parts for each Product object
        private BindingList<Part> associatedParts = new BindingList<Part>();

        // Keeps count of the # of Products for the ProductID
        public static int productCount;

        #endregion

        #region Constructor

        public Product()
        {
            ProductID = productCount++;
            Name = "null";
            InStock = 0;
            Price = 0.00M;
            Min = 0;
            Max = 0;
        }

        /// <summary>
        /// Default constructor for Product class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inStock"></param>
        /// <param name="price"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// 
        public Product(string name, int inStock, decimal price, int min, int max)
        {
            ProductID = productCount++;
            Name = name;
            InStock = InStock;
            Price = price;
            Min = min;
            Max = max;
        }

        #endregion

        #region Public Properties


        /// <summary>
        /// Gets and sets the BindingList AssociatedParts
        /// </summary>
        public BindingList<Part> AssociatedParts { get { return associatedParts; } set { associatedParts = value; } }

        /// <summary>
        /// Gets and sets the product id
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// Gets and sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets and sets the in stock quantity
        /// </summary>
        public int InStock { get; set; }

        /// <summary>
        /// Gets and sets the minimum quantity
        /// </summary>
        public int Min { get; set; }
        /// <summary>
        /// Gets and sets the maximum quantity
        /// </summary>
        public int Max { get; set; }

        #endregion

        #region Methods

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public bool RemoveAssociatedPart(int requestedPartID)
        {
            bool success = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == requestedPartID)
                {
                    AssociatedParts.Remove(part);
                    return success = true;
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
        public Part lookupAssociatedPart(int requestedPartID)
        {
            //todo
            return null;
        }

        #endregion

    }
}
