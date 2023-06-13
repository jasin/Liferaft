using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseAccess.Entities;

public enum AccountType : long
{
    General = 1000,
    Payroll = 1002,
    Savings = 1030,
    CertificateOfDeposit = 1040
}

[Table("lgract", Schema = "dbo")]
public partial class LedgerAccount
{
    public Guid Idnum { get; set; }

    public long Recnum { get; set; }

    public string Shtnme { get; set; } = null!;

    public string Lngnme { get; set; } = null!;

    public byte Subact { get; set; }

    public long? Sumact { get; set; }

    public byte? Csttyp { get; set; }

    public decimal Begbal { get; set; }

    public decimal Endbal { get; set; }

    public long Nxtchk { get; set; }

    public long Nxtdep { get; set; }

    public decimal Strbal { get; set; }

    public byte Acttyp { get; set; }

    public byte Dbtcrd { get; set; }

    public string Ntetxt { get; set; } = null!;

    public byte Jobsub { get; set; }

    public byte Iscrcd { get; set; }

    public DateTime? Insdte { get; set; }

    public string? Insusr { get; set; }

    public DateTime? Upddte { get; set; }

    public string? Updusr { get; set; }

    public byte Inactv { get; set; }

    public string BnkId { get; set; } = null!;

    public long TrnId { get; set; }

    public virtual ICollection<LedgerAccount> InverseSumactNavigation { get; } = new List<LedgerAccount>();

    public virtual ICollection<LedgerBalance> LgrbalIdrefNavigations { get; } = new List<LedgerBalance>();

    public virtual ICollection<LedgerBalance> LgrbalLgractNavigations { get; } = new List<LedgerBalance>();

    public virtual LedgerAccount? SumactNavigation { get; set; }
}
