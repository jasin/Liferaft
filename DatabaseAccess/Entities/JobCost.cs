using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseAccess.Entities;

[Table("Jobcst", Schema = "dbo")]
public partial class JobCost
{
    public Guid Idnum { get; set; }

    public long Recnum { get; set; }

    public string Wrkord { get; set; } = null!;

    public long Jobnum { get; set; }

    public string Trnnum { get; set; } = null!;

    public string Dscrpt { get; set; } = null!;

    public DateTime? Trndte { get; set; }

    public DateTime? Entdte { get; set; }

    public byte Actprd { get; set; }

    public byte Srcnum { get; set; }

    public byte Status { get; set; }

    public byte Bllsts { get; set; }

    public long Phsnum { get; set; }

    public decimal Cstcde { get; set; }

    public byte Csttyp { get; set; }

    public long? Vndnum { get; set; }

    public long? Eqpnum { get; set; }

    public long? Empnum { get; set; }

    public long? Payrec { get; set; }

    public byte Paytyp { get; set; }

    public decimal Csthrs { get; set; }

    public decimal Cstamt { get; set; }

    public decimal Blgqty { get; set; }

    public decimal Blgamt { get; set; }

    public decimal Pieces { get; set; }

    public long Lgrrec { get; set; }

    public byte Blgunt { get; set; }

    public byte Eqptyp { get; set; }

    public byte Eqpunt { get; set; }

    public decimal Eqpqty { get; set; }

    public decimal Grswge { get; set; }

    public byte Ovrrde { get; set; }

    public decimal Blgttl { get; set; }

    public byte Active { get; set; }

    public long Acrinv { get; set; }

    public decimal Shwamt { get; set; }

    public decimal Ovhamt { get; set; }

    public decimal Pftamt { get; set; }

    public byte Taxabl { get; set; }

    public string Usrnme { get; set; } = null!;

    public string Ntetxt { get; set; } = null!;

    public short Postyr { get; set; }

    public DateTime? Insdte { get; set; }

    public string? Insusr { get; set; }

    public DateTime? Upddte { get; set; }

    public string? Updusr { get; set; }

    public virtual Employee? EmpnumNavigation { get; set; }

    public virtual PayrollRecord? PayrecNavigation { get; set; }
}
