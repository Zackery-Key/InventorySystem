using System;
using System.Windows.Forms;

namespace ZackeryKeyInventorySystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Inventory.AddPart(new Inhouse("Wheel", 5, 5.25M, 1, 5, 01001));
            Inventory.AddPart(new Outsourced("Brake", 6, 4.25M, 1, 8, "PedalBanks"));
            Inventory.AddProduct(new Product("Bike", 3, 149.99M, 1, 9));
            Inventory.AddProduct(new Product("SkateBoard", 7, 49.99M, 1, 12));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreenForm());
        }
    }
}
