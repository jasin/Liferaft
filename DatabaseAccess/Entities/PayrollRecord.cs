using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseAccess.Entities;

[Table("Payrec", Schema = "dbo")]
public partial class PayrollRecord
{
    public Guid Idnum { get; set; }

    public long Recnum { get; set; }

    public long Empnum { get; set; }

    public DateTime? Strprd { get; set; }

    public DateTime? Payprd { get; set; }

    public string Chknum { get; set; } = null!;

    public DateTime? Chkdte { get; set; }

    public string Taxste { get; set; } = null!;

    public decimal Salary { get; set; }

    public decimal Payrt1 { get; set; }

    public decimal Payrt2 { get; set; }

    public decimal Payrt3 { get; set; }

    public decimal Advnce { get; set; }

    public byte Paytyp { get; set; }

    public byte Status { get; set; }

    public byte Qtrnum { get; set; }

    public decimal Reghrs { get; set; }

    public decimal Ovthrs { get; set; }

    public decimal Prmhrs { get; set; }

    public decimal Sckhrs { get; set; }

    public decimal Vachrs { get; set; }

    public decimal Holhrs { get; set; }

    public decimal Pieces { get; set; }

    public decimal Ttlhrs { get; set; }

    public decimal Regpay { get; set; }

    public decimal Ovtpay { get; set; }

    public decimal Prmpay { get; set; }

    public decimal Sckpay { get; set; }

    public decimal Vacpay { get; set; }

    public decimal Holpay { get; set; }

    public decimal Pcerte { get; set; }

    public decimal Perdim { get; set; }

    public decimal Mscpay { get; set; }

    public decimal Grspay { get; set; }

    public decimal Dedttl { get; set; }

    public decimal Addttl { get; set; }

    public decimal Netpay { get; set; }

    public DateTime? Entdte { get; set; }

    public decimal Pcpyrt { get; set; }

    public byte Dirdep { get; set; }

    public long Lgrrec { get; set; }

    public string Usrnme { get; set; } = null!;

    public string Ntetxt { get; set; } = null!;

    public int Ddpbch { get; set; }

    public decimal Vacatn { get; set; }

    public decimal Acahr1 { get; set; }

    public decimal Acahr2 { get; set; }

    public byte Acaovr { get; set; }

    public decimal Cmpgrs { get; set; }

    public decimal Cmpwge { get; set; }

    public DateTime? Insdte { get; set; }

    public string? Insusr { get; set; }

    public DateTime? Upddte { get; set; }

    public string? Updusr { get; set; }

    public decimal Accsck { get; set; }

    public decimal Ytdgrs { get; set; }

    public decimal Ytdnet { get; set; }

    public decimal Accvac { get; set; }

    public decimal Fedsck { get; set; }

    public decimal Stdsck { get; set; }

    public virtual Employee EmpnumNavigation { get; set; } = null!;

    public virtual ICollection<JobCost> Jobcsts { get; } = new List<JobCost>();
}
