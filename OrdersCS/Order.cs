using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Orders
{
    public class Order : IOrderCore
    {
        public Order(IOrderCore orderCore, long price, uint quantity, bool isBuySide)
        {
            Price = price;
            InitialQuantity = quantity;
            CurrentQuantity = quantity;
            IsBuySide = isBuySide;

        }

        public Order(ModifyOrder modifyOrder) : this(modifyOrder, modifyOrder.Price, modifyOrder.Quantity, modifyOrder.IsBuySide)
        {
        }

        // PROPERTIES //
        public long Price { get; private set; }
        public long InitialQuantity { get; private set; }
        public long CurrentQuantity { get; private set; }
        public bool IsBuySide{ get; private set; }
        public long OrderId => _orderCore.OrderId;
        public string Username => _orderCore.Username;
        public int SecurityId => _orderCore.SecurityId;

        // METHODS //
        public void IncreaseQuantity(uint quantityDelta)
        {
            CurrentQuantity += quantityDelta;
        }
        public void DecreaseQuantity(uint quantityDelta)
        {
            if (quantityDelta > CurrentQuantity)
                throw new InvalidOperationException($"Quantity Delta > Current Quantity for OrderId={OrderId}");
            CurrentQuantity -= quantityDelta;
        }

        // FIELDS//
        private readonly IOrderCore _orderCore;
    }
}
