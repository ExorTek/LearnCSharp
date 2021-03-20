using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {//ExorTek(Mehmet Demirel)
        static void Main(string[] args)
        {
            Product hardDisk = new Product(50);
            hardDisk.ProdctName = "Hard Disk";

            Product phone = new Product(50);
            phone.ProdctName = "Phone";

            phone.StockControlEvent += Phone_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                hardDisk.Sell(10);
                phone.Sell(10);
                Console.ReadLine();

            }


            Console.ReadLine();

        }

        private static void Phone_StockControlEvent()
        {
            Console.WriteLine("Phone about to finish !");
        }
    }
}
