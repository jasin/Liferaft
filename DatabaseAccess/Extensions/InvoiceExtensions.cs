using DatabaseAccess.Entities.Interfaces;
using DatabaseAccess.Enumerations;

namespace DatabaseAccess.Extensions;

public static class InvoiceExtensions
{
    public static IQueryable<IInvoices> FilterByStatus(this IQueryable<IInvoices> invoices, InvoiceStatus status)
    {
        return invoices.Where(inv => inv.Status == (byte)status);
    }

    public static IQueryable<IInvoices> FilterByDueDate(this IQueryable<IInvoices> invoices,
        DateTime fromDueDate,
        DateTime toDueDate)
    {
        
        return invoices.Where(inv => inv.Duedte >= fromDueDate && inv.Duedte <= toDueDate);
    }
}