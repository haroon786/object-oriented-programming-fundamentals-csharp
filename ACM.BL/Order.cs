﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {
        }
        public Order(int orderId)
        {
            OrderId = orderId;
            Orderitem = new List<Orderitem>();
        }
        public List<Orderitem> Orderitem { get; set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }

        //public Order Retrive(int orderId)
        //{
        //    return new Order();
        //}

        //public bool Save()
        //{
        //    return true;
        //}
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
