using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace Store.Domain.Entities;

public class OrderItem : Entity
{
    public OrderItem(Product product, int quantity)
    {
        Validate(product, quantity);

        Product = product;
        Price = Product != null ? product.Price : 0;
        Quantity = quantity;
    }

    private void Validate(Product product, int quantity)
    {
        AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotNull(product, "Product", "Invalid Product")
                .IsGreaterThan(quantity, 0, "Quantity", "Products cannot stay in 0 items!")
        );
    }

    public Product? Product { get; private set; }
    public decimal Price { get; private set; }
    public int Quantity { get; private set; }

    public decimal Total()
    {
        return Price * Quantity;
    }
}
