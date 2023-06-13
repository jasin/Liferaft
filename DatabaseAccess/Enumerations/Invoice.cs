namespace DatabaseAccess.Enumerations;

public enum InvoiceStatus : byte
{
    Open = 1,
    Review = 2,
    Dispute = 3,
    Paid = 4,
    Void = 5
}