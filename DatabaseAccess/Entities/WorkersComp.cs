namespace DatabaseAccess.Entities;

public partial class WorkersComp
{
    public Guid Idnum { get; set; }

    public int Recnum { get; set; }

    public string Cdenme { get; set; } = null!;

    public string Taxste { get; set; } = null!;

    public decimal Pctrte { get; set; }

    public decimal Emehrs { get; set; }

    public decimal Emrhrs { get; set; }

    public decimal Libins { get; set; }

    public decimal Expmod { get; set; }

    public decimal Addmod { get; set; }

    public decimal Maxwge { get; set; }

    public string Ntetxt { get; set; } = null!;

    public DateTime? Insdte { get; set; }

    public string? Insusr { get; set; }

    public DateTime? Upddte { get; set; }

    public string? Updusr { get; set; }

    public string Inactv { get; set; } = null!;

    public virtual ICollection<Employee> Employs { get; } = new List<Employee>();
}
