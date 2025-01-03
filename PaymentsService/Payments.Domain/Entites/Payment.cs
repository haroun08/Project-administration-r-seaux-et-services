namespace Payments.Domain.Entities;

public class Payment {
    public int Id {get;set;}
    public int ReferenceId {get;set;}
    public decimal Price {get;set;}
    public PaymentStatus status {get;set;}
}