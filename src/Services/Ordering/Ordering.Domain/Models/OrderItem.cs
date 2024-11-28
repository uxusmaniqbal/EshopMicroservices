namespace Ordering.Domain.Models
{
    public class OrderItem : Entity<OrderItemId>
    {
        /* 
         orderId and productId both are guid and can cause primitive obsession since parms value can be swapped resulting in 
         invalid order and productId this is refer as primitive obsession to avoid primitive obsession define strongly type id's. 
         */

        internal OrderItem(OrderId orderId, ProductId productId, int quantity, decimal price)
        {
            Id = OrderItemId.Of(Guid.NewGuid());
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }

        public OrderId OrderId { get; private set; } = default!;
        public ProductId ProductId { get; private set; } = default!;
        public int Quantity { get; private set; } = default!;
        public decimal Price { get; private set; } = default!;
    }
}
