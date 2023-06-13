using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseAccess.Entities;

[Table("Paygrp", Schema = "dbo")]
public partial class PayGroup
{
    public Guid Idnum { get; set; }

    public int Recnum { get; set; }

    public string Grpnme { get; set; } = null!;

    public string Wrkcls { get; set; } = null!;

    public byte Clslvl { get; set; }

    public decimal Clsprc { get; set; }

    public string Clscde { get; set; } = null!;

    public string Ovrrde { get; set; } = null!;

    public decimal Payrt1 { get; set; }

    public decimal Payrt2 { get; set; }

    public decimal Payrt3 { get; set; }

    public decimal Pcerte { get; set; }

    public int? Uninum { get; set; }

    public string Ntetxt { get; set; } = null!;

    public DateTime? Insdte { get; set; }

    public string? Insusr { get; set; }

    public DateTime? Upddte { get; set; }

    public string? Updusr { get; set; }

    public string Inactv { get; set; } = null!;

    public virtual ICollection<Employee> Employs { get; } = new List<Employee>();

    public virtual PayrollUnion? UninumNavigation { get; set; }
}
