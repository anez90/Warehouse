using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class Juice : EcoStockItem
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
                if (value == "apple" || value == "orange")
                    type = value;
                else
                    throw new Exception("Wrong value");
            }
        }
        public Juice(int id, string name, int stockCount, string mark, string type) : base(id, name, stockCount, mark)
        {
            Type = type;
        }
        public override string ToString() => $" {base.ToString()}, Type: {Type}";
    }
}
