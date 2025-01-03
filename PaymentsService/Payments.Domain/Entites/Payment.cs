namespace Payments.Domain.Entities;

public class Payment {
    public int Id {get;set;}
    public int ReferenceId {get;set;}
    public int Price {get;set;}
    public PaymentStatus status {get;set;}
}