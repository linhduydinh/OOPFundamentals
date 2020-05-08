﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BusinessLayer
{
    public class OrderItem
    {

        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public decimal? PurchasePrice { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public OrderItem Retrieve(int productId)
        {
            return new OrderItem();
        }

        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            return Quantity > 0 && ProductId > 0 && PurchasePrice != null;
        }
    }
}
