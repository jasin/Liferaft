using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseAccess.Entities;

[Table("Lgrbal", Schema = "dbo")]
public partial class LedgerBalance
{
    public Guid Idnum { get; set; }

    public Guid Idref { get; set; }

    public long Recnum { get; set; }

    public long Lgract { get; set; }

    public short Postyr { get; set; }

    public byte Actprd { get; set; }

    public decimal Balnce { get; set; }

    public decimal Budget { get; set; }

    public DateTime? Insdte { get; set; }

    public string? Insusr { get; set; }

    public DateTime? Upddte { get; set; }

    public string? Updusr { get; set; }

    public virtual LedgerAccount IdrefNavigation { get; set; } = null!;

    public virtual LedgerAccount LedgerAccountNavigation { get; set; } = null!;
}
