using System.ComponentModel;

namespace ZackeryKeyInventorySystem
{
    class Inventory
    {

        #region Parts

        #region Parts Binding List and Method
        
        // Creates a BindingList of Parts
        private static BindingList<Part> allParts = new BindingList<Part>();

        /// <summary>
        /// Gets and sets Binding List for AllParts
        /// </summary>
        public static BindingList<Part> AllParts { get { return allParts; } set { allParts = value; } }

        #endregion

        #region Part Properties

        // Public Properties
        public static Part CurrentPart { get; set; }
        public static int CurrentPartID { get; set; }
        public static int CurrentPartIndex { get; set; }

        #endregion

        #region Parts Methods

        /// <summary>
        /// Adds new Part object to AllParts BindingList
        /// </summary>
        /// <param name="newPart"></param>
        public static void AddPart(Part newPart) { AllParts.Add(newPart); }

        /// <summary>
        /// Deletes Part object from AllParts BindingList
        /// </summary>
        /// <param name="requestedPartID"></param>
        /// <returns></returns>
        public static bool DeletePart(Part requestedPart)
        {
            bool success = false;
            foreach (Part part in AllParts)
            {
                if (part == requestedPart)
                {
                    AllParts.Remove(part);
                    return success = true;
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }

        /// <summary>
        /// Loops through BindingList and finds requested part
        /// </summary>
        /// <param name="requestedPartID"></param>
        /// <returns></returns>
        public static Part LookupPart(int requestedPartID)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                // Checks to see if PartID in AllParts matches the requestedPartID
                if (AllParts[i].PartID.Equals(requestedPartID))
                {
                    // Returns the data at that listed index
                    CurrentPartIndex = i;
                    return AllParts[i];
                }
            }

            // Resets the CurrentPartIndex
            CurrentPartIndex = -1;

            // Breaks out of the method
            return null;
        }

        /// <summary>
        /// Updates the part so there are no duplicate records
        /// </summary>
        /// <param name="index"></param>
        /// <param name="part"></param>
        public static void UpdatePart(int index, Part part)
        {
            // Inserts the new Part
            AllParts.Insert(index, part);

            // Removes the old part at new index
            AllParts.RemoveAt(index + 1);
        }

        #endregion

        #endregion

        #region Products

        #region Products Binding List and Methods

        // Creates a BindingList of Products
        private static BindingList<Product> products = new BindingList<Product>();

        /// <summary>
        /// Gets and sets Binding List for Products
        /// </summary>
        public static BindingList<Product> Products { get { return products; } set { products = value; } }

        #endregion

        #region Product Properties

        // Public Properties
        public static Product CurrentProduct { get; set; }
        public static int CurrentProductID { get; set; }
        public static int CurrentProductIndex { get; set; }

        #endregion

        #region Product Methods

        /// <summary>
        /// Adds new Product object to Products BindingList
        /// </summary>
        /// <param name="product"></param>
        public static void AddProduct(Product product) { Products.Add(product); }

        /// <summary>
        /// Deletes Product object from Products BindingList
        /// </summary>
        /// <param name="requestedProductID"></param>
        /// <returns></returns>
        public static bool RemoveProduct(int requestedProductID)
        {
            bool success = false;
            foreach (Product product in Products)
            {
                if (product.ProductID == requestedProductID)
                {
                    Products.Remove(product);
                    return success = true;
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }

        /// <summary>
        /// Loops through BindingList and finds requested product
        /// </summary>
        /// <param name="requestedProductID"></param>
        /// <returns></returns>
        public static Product LookupProduct(int requestedProductID)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                // Checks to see if ProductID in Products BindingList matches the requestedProductID
                if (Products[i].ProductID.Equals(requestedProductID))
                {
                    // Returns the data at that listed index
                    CurrentProductIndex = i;
                    return Products[i];
                }
            }

            // Resets the CurrentProductIndex
            CurrentProductIndex = -1;

            // Breaks out of the method
            return null;
        }

        /// <summary>
        /// Updates the product so there are no duplicates
        /// </summary>
        /// <param name="index"></param>
        /// <param name="product"></param>
        public static void UpdateProduct(int index, Product product)
        {
            // Inserts the new Product
            Products.Insert(index, product);

            // Removes the old Product at new index
            Products.RemoveAt(index + 1);
        }


        #endregion

        #endregion

    }
}
