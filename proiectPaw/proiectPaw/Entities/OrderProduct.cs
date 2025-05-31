using System;

public class OrderProduct
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }

    public OrderProduct()
    {
        Id = Guid.NewGuid();
    }

    public OrderProduct(Guid id, Guid orderId, Guid productId, int quantity)
    {
        Id = id;
        OrderId = orderId;
        ProductId = productId;
        Quantity = quantity;
    }

}
