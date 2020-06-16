using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Orderitem
    {
        public Orderitem()
        {

        }

        public Orderitem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Qunatity { get; set; }

        public Orderitem Retrieve(int OrderItemId)
        {
            return new Orderitem();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {

            var isvalid = true;
            if (Qunatity <=0) isvalid = false;
            if (ProductId <=0 ) isvalid = false;
            if (PurchasePrice == null) isvalid = false;

            return isvalid;
        }
    }
}
