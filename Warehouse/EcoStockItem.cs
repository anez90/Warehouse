using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    abstract class EcoStockItem : StockItem
    {
        string mark;

        public string Mark
        {
            get
            {
                return mark;
            }

            set
            {
                if (value == "Krav" || value == "EG" || value == "krav" || value == "eg")//ändra till små/stora
                    mark = value;
                else
                    throw new Exception("Wrong Value");
            }
        }

        protected EcoStockItem(int id, string name, int stockCount, string mark) : base(id, name, stockCount)
        {
            Mark = mark;
        }

        public override string ToString() => $" {base.ToString()}, Mark: {Mark}";

    }
}
