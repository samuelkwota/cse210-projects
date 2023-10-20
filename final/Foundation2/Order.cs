class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0.0;
        foreach (Product product in products)
        {
            totalPrice += product.GetPrice();
        }

        if (customer.IsInUSA())
        {
            totalPrice += 5.0; // USA shipping cost
        }
        else
        {
            totalPrice += 35.0; // International shipping cost
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in products)
        {
            label += $"{product.GetName()} ({product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + customer.GetShippingAddress();
    }
}
