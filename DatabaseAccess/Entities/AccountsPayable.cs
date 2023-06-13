using System.ComponentModel.DataAnnotations.Schema;
using DatabaseAccess.Entities.Interfaces;

namespace DatabaseAccess.Entities;

[Table("Acpinv", Schema = "dbo")]
public partial class AccountsPayable : IInvoices
{
    public Guid Idnum { get; set; }

    public long Recnum { get; set; }

    public string Invnum { get; set; } = null!;

    public string Pchord { get; set; } = null!;

    public string Ctcnum { get; set; } = null!;

    public long Vndnum { get; set; }

    public long? Jobnum { get; set; }

    public long? Phsnum { get; set; }

    public string Dscrpt { get; set; } = null!;

    public DateTime? Invdte { get; set; }

    public DateTime? Duedte { get; set; }

    public string Refnum { get; set; } = null!;

    public DateTime? Dscdte { get; set; }

    public byte Invtyp { get; set; }

    public byte Status { get; set; }

    public string Payee2 { get; set; } = null!;

    public string Usrdf1 { get; set; } = null!;

    public string Usrdf2 { get; set; } = null!;

    public decimal Dscavl { get; set; }

    public decimal Retain { get; set; }

    public decimal Setpay { get; set; }

    public decimal Amtpad { get; set; }

    public decimal Dsctkn { get; set; }

    public decimal Invttl { get; set; }

    public decimal Adjust { get; set; }

    public decimal Freigh { get; set; }

    public decimal Ttlpad { get; set; }

    public decimal Invbal { get; set; }

    public decimal Invnet { get; set; }

    public byte Actper { get; set; }

    public DateTime? Entdte { get; set; }

    public long Lgrrec { get; set; }

    public string Usrnme { get; set; } = null!;

    public int Btcnum { get; set; }

    public byte Hotlst { get; set; }

    public string Shpnum { get; set; } = null!;

    public decimal Cmpamt { get; set; }

    public decimal Usetax { get; set; }

    public string Ntetxt { get; set; } = null!;

    public string Vodrec { get; set; } = null!;

    public decimal Subttl { get; set; }

    public decimal Hldamt { get; set; }

    public decimal Hldbll { get; set; }

    public decimal Hldrem { get; set; }

    public decimal Pstamt { get; set; }

    public decimal Qstamt { get; set; }

    public decimal Gstamt { get; set; }

    public decimal Hstamt { get; set; }

    public decimal Invamt { get; set; }

    public decimal Slstax { get; set; }

    public short Postyr { get; set; }

    public short? Taxcde { get; set; }

    public decimal Rcpamt { get; set; }

    public DateTime? Insdte { get; set; }

    public string? Insusr { get; set; }

    public DateTime? Upddte { get; set; }

    public string? Updusr { get; set; }

    public string Apinte { get; set; } = null!;

    public int? Usedst { get; set; }

    public decimal Usettl { get; set; }
}
