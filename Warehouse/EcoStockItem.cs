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
                if (value == "Krav" || value == "EG")//ändra till små/stora
                    mark = value;
                else
                    throw new Exception("Wrong Value");
            }
        }
        public EcoStockItem(int id, string name, string mark) : base(id, name)
        {
            Mark = mark;
        }
        public override string ToString() => $" {base.ToString()}, Mark: {Mark}";

    }
}
