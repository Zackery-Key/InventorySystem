namespace ZackeryKeyInventorySystem
{
    class Inhouse : Part
    {
        #region Constructor
        /// <summary>
        /// Default constructor for Inhouse part: calls from base class Part
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inStock"></param>
        /// <param name="price"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="machineID"></param>
        public Inhouse(string name, int inStock, decimal price, int min, int max, int machineID)
            : base(name, inStock, price, min, max)
        {
            MachineID = machineID;
        }

        #endregion

        /// <summary>
        /// Gets and sets the machine ID for in-house parts
        /// </summary>
        public int MachineID { get; set; }
    }
}
