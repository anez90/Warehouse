using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    abstract class StockItem
    {
        int id;
        string name;
        static int stockCount;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public static int StockCount
        {
            get
            {
                return stockCount;
            }

            private set
            {
                stockCount = value;
            }
        }

        static StockItem()
        {
            stockCount = 0;
        }
        public StockItem()
        {
            StockCount++;
        }
        public StockItem(int id, string name) : this()
        {
            Id = id;
            Name = name;
        }

        public override string ToString() => $"Id: {Id}, Name: {Name}";



    }
}
