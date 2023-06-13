namespace DatabaseAccess.Entities.Interfaces;

public interface IInvoices
{
    Guid Idnum { get; set; }
    long Recnum { get; set; }
    public byte Status { get; set; }
    public decimal Invnet { get; set; }
    DateTime? Duedte { get; set; }
}