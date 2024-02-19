using System;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        
        Address a1 = new Address("Poblacion Zone 3", "Del Gallego", "Camarines Sur", "Philippines", false);
        Customer c1 = new Customer("Angelo Caringal", a1);

        Product p1 = new Product("Sardines","s100g",20,4);
        Product p2 = new Product("Cooking Oil","co1lb",50,1);
        Product p3 = new Product("Soap","s150g",30,2);
        

        order.SetProducts(p1);
        order.SetProducts(p2);
        order.SetProducts(p3);

        order.SetCustomers(c1);

        order.GetPackingLabel();
        order.DisplayCost();
        order.GetShippingLabel();
 

    }
}