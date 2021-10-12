namespace ZackeryKeyInventorySystem
{
    abstract class Part
    {

        public static int partCount;

        #region Constructor

        /// <summary>
        /// Default constructor for Part Class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inStock"></param>
        /// <param name="price"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public Part(string name, int inStock, decimal price, int min, int max)
        {
            PartID = partCount++;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
        #endregion

        #region Public Properties

        /// <summary>
        /// Sets and gets the partID
        /// </summary>
        public int PartID { get; set; }

        /// <summary>
        /// Sets and gets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Sets and gets the price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Sets and gets the in stock quantity
        /// </summary>
        public int InStock { get; set; }

        /// <summary>
        /// Sets and gets the minimum quantity
        /// </summary>
        public int Min { get; set; }

        /// <summary>
        /// Sets and gets the maximum quantity
        /// </summary>
        public int Max { get; set; }
        #endregion

    }
}
