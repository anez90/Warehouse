using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class Plate : StockItem
    {
        string type;
        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                if (value == "flat" || value == "deep")
                    type = value;
                else
                    throw new Exception("Wrong value");
            }
        }
        public Plate(int id, string name, int stockCount, string type) : base(id, name, stockCount)
        {
            Type = type;
        }
        public override string ToString() => $" {base.ToString()}, Type: {Type}";
    }
}
