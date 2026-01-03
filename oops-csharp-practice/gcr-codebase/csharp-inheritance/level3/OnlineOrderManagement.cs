using System;

// Base class: Order
class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }

    public Order(int orderId, DateTime orderDate)
    {
        this.OrderId = orderId;
        this.OrderDate = orderDate;
    }

    // Virtual method to get the status of the order
    public virtual string GetOrderStatus()
    {
        return "Order Placed";
    }
}

// Subclass: ShippedOrder (inherits from Order)
class ShippedOrder : Order
{
    public string TrackingNumber { get; set; }

    public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        this.TrackingNumber = trackingNumber;
    }

    // Override to show shipped status
    public override string GetOrderStatus()
    {
        return $"Shipped (Tracking Number: {TrackingNumber})";
    }
}

// Subclass: DeliveredOrder (inherits from ShippedOrder)
class DeliveredOrder : ShippedOrder
{
    public DateTime DeliveryDate { get; set; }

    public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        this.DeliveryDate = deliveryDate;
    }

    // Override to show delivered status
    public override string GetOrderStatus()
    {
        return $"Delivered on {DeliveryDate.ToShortDateString()} (Tracking Number: {TrackingNumber})";
    }
}

// Program to test the hierarchy
class Program
{
    static void Main()
    {
        // Base order
        Order order1 = new Order(1001, DateTime.Now.AddDays(-5));
        Console.WriteLine($"Order ID: {order1.OrderId}, Status: {order1.GetOrderStatus()}");

        // Shipped order
        ShippedOrder order2 = new ShippedOrder(1002, DateTime.Now.AddDays(-3), "TRK12345");
        Console.WriteLine($"Order ID: {order2.OrderId}, Status: {order2.GetOrderStatus()}");

        // Delivered order
        DeliveredOrder order3 = new DeliveredOrder(1003, DateTime.Now.AddDays(-7), "TRK67890", DateTime.Now);
        Console.WriteLine($"Order ID: {order3.OrderId}, Status: {order3.GetOrderStatus()}");
    }
}
