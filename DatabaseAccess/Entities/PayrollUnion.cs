using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseAccess.Entities;

[Table("Payuni", Schema = "dbo")]
public partial class PayrollUnion
{
    public Guid Idnum { get; set; }

    public int Recnum { get; set; }

    public string Uninme { get; set; } = null!;

    public string Addrs1 { get; set; } = null!;

    public string Addrs2 { get; set; } = null!;

    public string Ctynme { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zipcde { get; set; } = null!;

    public string Phnnum { get; set; } = null!;

    public int Rppact { get; set; }

    public DateTime? Insdte { get; set; }

    public string? Insusr { get; set; }

    public DateTime? Upddte { get; set; }

    public string? Updusr { get; set; }

    public virtual ICollection<Employee> Employs { get; } = new List<Employee>();

    public virtual ICollection<PayGroup> Paygrps { get; } = new List<PayGroup>();
}
