namespace ZackeryKeyInventorySystem
{
    class Outsourced : Part
    {

        #region Constructor

        /// <summary>
        /// Default contructor for Outsourced class (Part Base Class)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inStock"></param>
        /// <param name="price"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="companyName"></param>
        public Outsourced(string name, int inStock, decimal price, int min, int max, string companyName)
            : base(name, inStock, price, min, max)
        {
            CompanyName = companyName;
        }
        #endregion

        /// <summary>
        /// Gets and sets the company name for outsourced parts
        /// </summary>
        public string CompanyName { get; set; }
    }
}
