using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseAccess.Entities;

public enum EmployeeStatus
{
    Current = 1,
    OnLeave = 2,
    Quit = 3,
    LaidOff = 4,
    Terminated = 5,
    OnProbation = 6,
    Deceased = 7,
    Retired = 8
}

[Table("Employ", Schema = "dbo")]
public partial class Employee
{
    public Guid Idnum { get; set; }

    public long Recnum { get; set; }

    public string Lstnme { get; set; } = null!;

    public string Fstnme { get; set; } = null!;

    public string Midini { get; set; } = null!;

    public byte Status { get; set; }

    public string Addrs1 { get; set; } = null!;

    public string Addrs2 { get; set; } = null!;

    public string Ctynme { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zipcde { get; set; } = null!;

    public string Phnnum { get; set; } = null!;

    public string Pagnum { get; set; } = null!;

    public string Faxnum { get; set; } = null!;

    public string Cllphn { get; set; } = null!;

    public string Homnum { get; set; } = null!;

    public string EMail { get; set; } = null!;

    public string Socsec { get; set; } = null!;

    public long? Eqpnum { get; set; }

    public DateTime? Dtebth { get; set; }

    public DateTime? Dtehre { get; set; }

    public DateTime? Dteina { get; set; }

    public DateTime? Lstrse { get; set; }

    public byte Gender { get; set; }

    public byte Mrtsts { get; set; }

    public byte Hertge { get; set; }

    public int Paypst { get; set; }

    public int Wrkcmp { get; set; }

    public byte Empcmp { get; set; }

    public byte Crtrpt { get; set; }

    public string Taxste { get; set; } = null!;

    public byte Payprd { get; set; }

    public int? Paygrp { get; set; }

    public decimal Payrt1 { get; set; }

    public decimal Payrt2 { get; set; }

    public decimal Payrt3 { get; set; }

    public decimal Salary { get; set; }

    public decimal Advdue { get; set; }

    public decimal Accsck { get; set; }

    public decimal Sckrte { get; set; }

    public byte Sckmth { get; set; }

    public decimal Accvac { get; set; }

    public decimal Vacrte { get; set; }

    public byte Vacmth { get; set; }

    public string Usrdf1 { get; set; } = null!;

    public string Usrdf2 { get; set; } = null!;

    public int? Loctax { get; set; }

    public int? Uninum { get; set; }

    public string Ntetxt { get; set; } = null!;

    public decimal Qt1grs { get; set; }

    public decimal Qt2grs { get; set; }

    public decimal Qt3grs { get; set; }

    public decimal Qt4grs { get; set; }

    public decimal Qt1fic { get; set; }

    public decimal Qt2fic { get; set; }

    public decimal Qt3fic { get; set; }

    public decimal Qt4fic { get; set; }

    public decimal Qt1med { get; set; }

    public decimal Qt2med { get; set; }

    public decimal Qt3med { get; set; }

    public decimal Qt4med { get; set; }

    public string Imgfle { get; set; } = null!;

    public byte I9verf { get; set; }

    public byte Exmovr { get; set; }

    public byte Emptyp { get; set; }

    public decimal Comisn { get; set; }

    public string Actnum { get; set; } = null!;

    public string Rtnmbr { get; set; } = null!;

    public byte Prente { get; set; }

    public byte Acttyp { get; set; }

    public decimal Depamt { get; set; }

    public string Actnm2 { get; set; } = null!;

    public string Rtnmb2 { get; set; } = null!;

    public byte Prent2 { get; set; }

    public byte Acttp2 { get; set; }

    public decimal Dp2amt { get; set; }

    public string Actnm3 { get; set; } = null!;

    public string Rtnmb3 { get; set; } = null!;

    public byte Prent3 { get; set; }

    public byte Acttp3 { get; set; }

    public decimal Dp3amt { get; set; }

    public string Actnm4 { get; set; } = null!;

    public string Rtnmb4 { get; set; } = null!;

    public byte Prent4 { get; set; }

    public byte Acttp4 { get; set; }

    public decimal Dp4amt { get; set; }

    public byte Dirdep { get; set; }

    public byte Retchk { get; set; }

    public string Fullst { get; set; } = null!;

    public string Fulfst { get; set; } = null!;

    public byte Rtetyp { get; set; }

    public byte Rtetp2 { get; set; }

    public byte Rtetp3 { get; set; }

    public byte Rtetp4 { get; set; }

    public byte Sckchk { get; set; }

    public byte Htglst { get; set; }

    public byte Hiract { get; set; }

    public string Pyreml { get; set; } = null!;

    public int? Locwrk { get; set; }

    public decimal Othded { get; set; }

    public decimal Nthzne { get; set; }

    public decimal Lbspfn { get; set; }

    public decimal Addtax { get; set; }

    public byte Eftsts { get; set; }

    public string Eftiid { get; set; } = null!;

    public string Eftrtn { get; set; } = null!;

    public string Eftact { get; set; } = null!;

    public byte Eftst2 { get; set; }

    public string Eftid2 { get; set; } = null!;

    public string Eftrt2 { get; set; } = null!;

    public string Eftac2 { get; set; } = null!;

    public byte Eftst3 { get; set; }

    public string Eftid3 { get; set; } = null!;

    public string Eftrt3 { get; set; } = null!;

    public string Eftac3 { get; set; } = null!;

    public byte Eftst4 { get; set; }

    public string Eftid4 { get; set; } = null!;

    public string Eftrt4 { get; set; } = null!;

    public string Eftac4 { get; set; } = null!;

    public DateTime? Fstwrk { get; set; }

    public DateTime? Lstroe { get; set; }

    public decimal Vacdue { get; set; }

    public DateTime? Insdte { get; set; }

    public string? Insusr { get; set; }

    public DateTime? Upddte { get; set; }

    public string? Updusr { get; set; }

    public byte W2elc { get; set; }

    public byte Acaelc { get; set; }

    public decimal Sckmax { get; set; }

    public decimal Sckbeg { get; set; }

    public int Paycls { get; set; }

    public byte Inactv { get; set; }

    public decimal Vacmax { get; set; }

    public decimal Vacbeg { get; set; }

    public decimal Scklmt { get; set; }

    public decimal Sckytd { get; set; }

    public decimal Fdskrt { get; set; }

    public decimal Fdsklm { get; set; }

    public decimal Fdsktd { get; set; }

    public decimal Vaclmt { get; set; }

    public decimal Vacytd { get; set; }

    public byte Eeoprx { get; set; }

    public byte W41C { get; set; }

    public byte W42C { get; set; }

    public decimal W43 { get; set; }

    public decimal W44A { get; set; }

    public decimal W44B { get; set; }

    public decimal W44C { get; set; }

    public DateTime? W4Dte { get; set; }

    public int? Soccde { get; set; }

    public byte Admacs { get; set; }

    public string Ncknme { get; set; } = null!;

    public virtual ICollection<JobCost> Jobcsts { get; } = new List<JobCost>();

    public virtual PayGroup? PaygrpNavigation { get; set; }

    public virtual ICollection<PayrollRecord> Payrecs { get; } = new List<PayrollRecord>();

    public virtual PayrollUnion? UninumNavigation { get; set; }

    public virtual WorkersComp WrkcmpNavigation { get; set; } = null!;
}
