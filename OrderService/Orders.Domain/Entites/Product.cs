namespace Orders.Domain.Entities;

public class Product 
{
    public Product(){
        this.Orders = new List<Order>();
    }
    public int Id {get;set;}
    public string Name {get;set;}
    public string Quantity {get;set;}
    public decimal UnitPrice {get;set;}

    public List<Order> Orders {get;private set;}



}