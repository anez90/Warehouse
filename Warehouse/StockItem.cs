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
        int stockCount;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                if(value > 0)
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
        public int StockCount
        {
            get
            {
                return stockCount;
            }

            set
            {
                if(value > 0)
                stockCount = value;
            }
        }

        protected StockItem(int id, string name, int stockCount)
        {
            Id = id;
            Name = name;
            StockCount = stockCount;
        }

        public override string ToString() => $"Id: {Id}, Name: {Name}, StockCout: {StockCount}";



    }
}
