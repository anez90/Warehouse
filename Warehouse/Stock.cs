using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class Stock
    {
        StockItem[] stockItems;
        

        public StockItem this[int index]
        {
            get
            {
                return stockItems[index];
            }
            private set
            {
                stockItems[index] = value;
            }
        }
        public int StockItemsLength
        {
            get { return stockItems.Length; }
        }

        public Stock()
        {
            stockItems = new StockItem[0];
        }

        public void AddItem(StockItem item)
        {
            StockItem[] newStock = new StockItem[stockItems.Length + 1];
            for (int i = 0; i < stockItems.Length; i++)
            {
                newStock[i] = stockItems[i];
            }
            newStock[newStock.Length - 1] = item;
            stockItems = newStock;
        }
        public StockItem GetItem(int itemId)
        {
            foreach (StockItem element in stockItems)
            {
                if (element.Id == itemId)
                {
                    return element;
                }

            }
            throw new Exception("Nothing");
        }

    }
    
}
