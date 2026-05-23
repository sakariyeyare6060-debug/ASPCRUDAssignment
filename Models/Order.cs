public class Order
{
    public int Id{get;set;}
    public string CustomerName {get;set;} = null!;

    public string ProductName {get; set;} = null!;

     public int Quantity {get; set;}

      public decimal Price {get; set;}

    public  DateTime? OrderDate{get;set;}

    
}