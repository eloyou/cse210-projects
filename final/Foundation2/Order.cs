using System;


public class Order
{
    private List<Product> _products = new List<Product>();
    private List<Customer> _customers = new List<Customer>();

    private double _totalCost;

    private int _shippingCost;



    public Order()
    {
       
    }

    public List<Customer> GetCustomers()
    {
        return _customers;
    }
    public void SetCustomers(Customer customer)
    {
        _customers.Add(customer);
    }
    public List<Product> GetProducts()
    {
        return _products;
    }
    public void SetProducts(Product product)
    {
        _products.Add(product);
    }
    public void GetPackingLabel()
    {
        int index = 1;
        foreach (Product product in _products)
        {
            Console.WriteLine($"Order No.{index} - Product ID.: {product.GetProductId()},{product.GetProductName()} / P{product.GetPrice()} x {product.GetQuantity()} = {product.GetTotalCost()}");
        }

    }

    public void GetShippingLabel()
    {
        foreach (Customer customer in _customers)
        {
            Console.WriteLine($"Shipping: This will send to {customer.GetName()} ({customer.GetAddress()})\n");

        }

    }

    public double GetTotalCost()
    {
        foreach (Product product in _products)
        {
           _totalCost += product.GetTotalCost() ;
        }

        return _totalCost;
    }

    public int GetShippingCost()
    {
        foreach (Customer customer in _customers)
        {
            if (customer.IsUSBase() == true)
            {
                _shippingCost = 5;
            }
            else
            {
                _shippingCost = 35;
            }
        }

        return _shippingCost;
    }

    public void DisplayCost()
    {
        Console.WriteLine($"Total Cost: P{GetTotalCost()}");
        Console.WriteLine($"Shipping Cost: P{GetShippingCost()}");
        Console.WriteLine($"Total: P{_totalCost + _shippingCost}");
    }
}

