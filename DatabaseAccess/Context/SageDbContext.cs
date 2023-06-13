using DatabaseAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAccess.Context;

public partial class SageDbContext : DbContext
{
    public SageDbContext(DbContextOptions<SageDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountsPayable> AccountsPayables { get; set; }

    public virtual DbSet<AccountsReceivable> AccountsReceivables { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<JobCost> JobCosts { get; set; }

    public virtual DbSet<LedgerAccount> LedgerAccounts { get; set; }

    public virtual DbSet<LedgerBalance> LedgerBalances { get; set; }

    public virtual DbSet<PayGroup> PayGroups { get; set; }

    public virtual DbSet<PayrollRecord> PayrollRecords { get; set; }

    public virtual DbSet<PayrollUnion> PayrollUnions { get; set; }

    public virtual DbSet<WorkersComp> WorkersComps { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountsPayable>(entity =>
        {
            entity.HasKey(e => e.Idnum).HasName("PK__acpinv__B471033646B9DB48");

            entity.ToTable("acpinv", tb =>
                {
                    tb.HasTrigger("TR:acpinv_NullPhase");
                    tb.HasTrigger("TRAD:dbo.acpinv_Audit");
                    tb.HasTrigger("TRAI:dbo.acpinv_Audit");
                    tb.HasTrigger("TRAU:dbo.acpinv:timestamping");
                    tb.HasTrigger("TRAU:dbo.acpinv_Audit");
                });

            entity.HasIndex(e => e.Btcnum, "IX:acpinv.btcnum").HasFillFactor(80);

            entity.HasIndex(e => e.Ctcnum, "IX:acpinv.ctcnum").HasFillFactor(80);

            entity.HasIndex(e => e.Dscrpt, "IX:acpinv.dscrpt").HasFillFactor(80);

            entity.HasIndex(e => e.Hotlst, "IX:acpinv.hotlst").HasFillFactor(80);

            entity.HasIndex(e => e.Invnum, "IX:acpinv.invnum").HasFillFactor(80);

            entity.HasIndex(e => e.Jobnum, "IX:acpinv.jobnum").HasFillFactor(80);

            entity.HasIndex(e => e.Lgrrec, "IX:acpinv.lgrrec").HasFillFactor(80);

            entity.HasIndex(e => e.Pchord, "IX:acpinv.pchord").HasFillFactor(80);

            entity.HasIndex(e => e.Recnum, "IX:acpinv.recnum")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.Setpay, "IX:acpinv.setpay").HasFillFactor(80);

            entity.HasIndex(e => e.Shpnum, "IX:acpinv.shpnum").HasFillFactor(80);

            entity.HasIndex(e => e.Usrdf1, "IX:acpinv.usrdf1").HasFillFactor(80);

            entity.HasIndex(e => e.Usrdf2, "IX:acpinv.usrdf2").HasFillFactor(80);

            entity.HasIndex(e => e.Usrnme, "IX:acpinv.usrnme").HasFillFactor(80);

            entity.HasIndex(e => e.Vndnum, "IX:acpinv.vndnum").HasFillFactor(80);

            entity.Property(e => e.Idnum)
                .ValueGeneratedNever()
                .HasColumnName("_idnum");
            entity.Property(e => e.Actper).HasColumnName("actper");
            entity.Property(e => e.Adjust)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("adjust");
            entity.Property(e => e.Amtpad)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("amtpad");
            entity.Property(e => e.Apinte)
                .HasDefaultValueSql("('')")
                .HasColumnName("apinte");
            entity.Property(e => e.Btcnum).HasColumnName("btcnum");
            entity.Property(e => e.Cmpamt)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("cmpamt");
            entity.Property(e => e.Ctcnum)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasColumnName("ctcnum");
            entity.Property(e => e.Dscavl)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("dscavl");
            entity.Property(e => e.Dscdte)
                .HasColumnType("date")
                .HasColumnName("dscdte");
            entity.Property(e => e.Dscrpt)
                .HasMaxLength(50)
                .HasColumnName("dscrpt");
            entity.Property(e => e.Dsctkn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("dsctkn");
            entity.Property(e => e.Duedte)
                .HasColumnType("date")
                .HasColumnName("duedte");
            entity.Property(e => e.Entdte)
                .HasColumnType("date")
                .HasColumnName("entdte");
            entity.Property(e => e.Freigh)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("freigh");
            entity.Property(e => e.Gstamt)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("gstamt");
            entity.Property(e => e.Hldamt)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("hldamt");
            entity.Property(e => e.Hldbll)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("hldbll");
            entity.Property(e => e.Hldrem)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("hldrem");
            entity.Property(e => e.Hotlst).HasColumnName("hotlst");
            entity.Property(e => e.Hstamt)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("hstamt");
            entity.Property(e => e.Insdte)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("insdte");
            entity.Property(e => e.Insusr)
                .HasMaxLength(128)
                .HasDefaultValueSql("(original_login())")
                .HasColumnName("insusr");
            entity.Property(e => e.Invamt)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("invamt");
            entity.Property(e => e.Invbal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("invbal");
            entity.Property(e => e.Invdte)
                .HasColumnType("date")
                .HasColumnName("invdte");
            entity.Property(e => e.Invnet)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("invnet");
            entity.Property(e => e.Invnum)
                .HasMaxLength(20)
                .HasColumnName("invnum");
            entity.Property(e => e.Invttl)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("invttl");
            entity.Property(e => e.Invtyp).HasColumnName("invtyp");
            entity.Property(e => e.Jobnum).HasColumnName("jobnum");
            entity.Property(e => e.Lgrrec).HasColumnName("lgrrec");
            entity.Property(e => e.Ntetxt)
                .HasDefaultValueSql("('')")
                .HasColumnName("ntetxt");
            entity.Property(e => e.Payee2)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("payee2");
            entity.Property(e => e.Pchord)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasColumnName("pchord");
            entity.Property(e => e.Phsnum).HasColumnName("phsnum");
            entity.Property(e => e.Postyr).HasColumnName("postyr");
            entity.Property(e => e.Pstamt)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("pstamt");
            entity.Property(e => e.Qstamt)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("qstamt");
            entity.Property(e => e.Rcpamt)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("rcpamt");
            entity.Property(e => e.Recnum)
                .ValueGeneratedOnAdd()
                .HasColumnName("recnum");
            entity.Property(e => e.Refnum)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasColumnName("refnum");
            entity.Property(e => e.Retain)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("retain");
            entity.Property(e => e.Setpay)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("setpay");
            entity.Property(e => e.Shpnum)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasColumnName("shpnum");
            entity.Property(e => e.Slstax)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("slstax");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Subttl)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("subttl");
            entity.Property(e => e.Taxcde).HasColumnName("taxcde");
            entity.Property(e => e.Ttlpad)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ttlpad");
            entity.Property(e => e.Upddte)
                .HasColumnType("datetime")
                .HasColumnName("upddte");
            entity.Property(e => e.Updusr)
                .HasMaxLength(128)
                .HasColumnName("updusr");
            entity.Property(e => e.Usedst).HasColumnName("usedst");
            entity.Property(e => e.Usetax)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("usetax");
            entity.Property(e => e.Usettl)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("usettl");
            entity.Property(e => e.Usrdf1)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("usrdf1");
            entity.Property(e => e.Usrdf2)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("usrdf2");
            entity.Property(e => e.Usrnme)
                .HasMaxLength(128)
                .HasDefaultValueSql("('')")
                .HasColumnName("usrnme");
            entity.Property(e => e.Vndnum).HasColumnName("vndnum");
            entity.Property(e => e.Vodrec)
                .HasMaxLength(300)
                .HasDefaultValueSql("('')")
                .HasColumnName("vodrec");
        });

        modelBuilder.Entity<AccountsReceivable>(entity =>
        {
            entity.HasKey(e => e.Idnum).HasName("PK__acrinv__B4710336735F614D");

            entity.ToTable("acrinv", tb =>
                {
                    tb.HasTrigger("TRAD:dbo.acrinv_Audit");
                    tb.HasTrigger("TRAI:dbo.acrinv_Audit");
                    tb.HasTrigger("TRAU:dbo.acrinv:timestamping");
                    tb.HasTrigger("TRAU:dbo.acrinv_Audit");
                });

            entity.HasIndex(e => e.Dscrpt, "IX:acrinv.dscrpt").HasFillFactor(80);

            entity.HasIndex(e => e.Duedte, "IX:acrinv.duedte").HasFillFactor(80);

            entity.HasIndex(e => e.Invdte, "IX:acrinv.invdte").HasFillFactor(80);

            entity.HasIndex(e => e.Invnum, "IX:acrinv.invnum").HasFillFactor(80);

            entity.HasIndex(e => e.Jobnum, "IX:acrinv.jobnum").HasFillFactor(80);

            entity.HasIndex(e => e.Lgrrec, "IX:acrinv.lgrrec").HasFillFactor(80);

            entity.HasIndex(e => e.Pchord, "IX:acrinv.pchord").HasFillFactor(80);

            entity.HasIndex(e => e.Recnum, "IX:acrinv.recnum")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.Status, "IX:acrinv.status").HasFillFactor(80);

            entity.HasIndex(e => e.Usrdf1, "IX:acrinv.usrdf1").HasFillFactor(80);

            entity.HasIndex(e => e.Usrdf2, "IX:acrinv.usrdf2").HasFillFactor(80);

            entity.HasIndex(e => e.Usrnme, "IX:acrinv.usrnme").HasFillFactor(80);

            entity.HasIndex(e => e.Vodrec, "IX:acrinv.vodrec").HasFillFactor(80);

            entity.Property(e => e.Idnum)
                .ValueGeneratedNever()
                .HasColumnName("_idnum");
            entity.Property(e => e.Actper).HasColumnName("actper");
            entity.Property(e => e.Amtpad)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("amtpad");
            entity.Property(e => e.Dscavl)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("dscavl");
            entity.Property(e => e.Dscdte)
                .HasColumnType("date")
                .HasColumnName("dscdte");
            entity.Property(e => e.Dscrpt)
                .HasMaxLength(50)
                .HasColumnName("dscrpt");
            entity.Property(e => e.Dsctkn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("dsctkn");
            entity.Property(e => e.Duedte)
                .HasColumnType("date")
                .HasColumnName("duedte");
            entity.Property(e => e.Entdte)
                .HasColumnType("date")
                .HasColumnName("entdte");
            entity.Property(e => e.Gstamt)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("gstamt");
            entity.Property(e => e.Gstsbj)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("gstsbj");
            entity.Property(e => e.Hldamt)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("hldamt");
            entity.Property(e => e.Hldbll)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("hldbll");
            entity.Property(e => e.Hldrem)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("hldrem");
            entity.Property(e => e.Hotlst).HasColumnName("hotlst");
            entity.Property(e => e.Hstamt)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("hstamt");
            entity.Property(e => e.Hstsbj)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("hstsbj");
            entity.Property(e => e.Imgfle)
                .HasDefaultValueSql("('')")
                .HasColumnName("imgfle");
            entity.Property(e => e.Insdte)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("insdte");
            entity.Property(e => e.Insusr)
                .HasMaxLength(128)
                .HasDefaultValueSql("(original_login())")
                .HasColumnName("insusr");
            entity.Property(e => e.Invamt)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("invamt");
            entity.Property(e => e.Invbal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("invbal");
            entity.Property(e => e.Invdte)
                .HasColumnType("date")
                .HasColumnName("invdte");
            entity.Property(e => e.Invnet)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("invnet");
            entity.Property(e => e.Invnum)
                .HasMaxLength(20)
                .HasColumnName("invnum");
            entity.Property(e => e.Invttl)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("invttl");
            entity.Property(e => e.Invtyp).HasColumnName("invtyp");
            entity.Property(e => e.Jobnum).HasColumnName("jobnum");
            entity.Property(e => e.Lgrrec).HasColumnName("lgrrec");
            entity.Property(e => e.Nontax)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("nontax");
            entity.Property(e => e.Ntetxt)
                .HasDefaultValueSql("('')")
                .HasColumnName("ntetxt");
            entity.Property(e => e.Pchord)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasColumnName("pchord");
            entity.Property(e => e.Phsnum).HasColumnName("phsnum");
            entity.Property(e => e.Postyr).HasColumnName("postyr");
            entity.Property(e => e.Pstamt)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("pstamt");
            entity.Property(e => e.Pstsbj)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("pstsbj");
            entity.Property(e => e.Recnum)
                .ValueGeneratedOnAdd()
                .HasColumnName("recnum");
            entity.Property(e => e.Refnum)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasColumnName("refnum");
            entity.Property(e => e.Retain)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("retain");
            entity.Property(e => e.Slstax)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("slstax");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Subttl)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("subttl");
            entity.Property(e => e.Taxabl)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("taxabl");
            entity.Property(e => e.Taxdst).HasColumnName("taxdst");
            entity.Property(e => e.Ttlpad)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ttlpad");
            entity.Property(e => e.Upddte)
                .HasColumnType("datetime")
                .HasColumnName("upddte");
            entity.Property(e => e.Updusr)
                .HasMaxLength(128)
                .HasColumnName("updusr");
            entity.Property(e => e.Usrdf1)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("usrdf1");
            entity.Property(e => e.Usrdf2)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("usrdf2");
            entity.Property(e => e.Usrnme)
                .HasMaxLength(128)
                .HasDefaultValueSql("('')")
                .HasColumnName("usrnme");
            entity.Property(e => e.Vodrec).HasColumnName("vodrec");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Idnum).HasName("PK__employ__B4710336A91D787B");

            entity.ToTable("employ", tb =>
                {
                    tb.HasTrigger("TRAD:dbo.employ_Audit");
                    tb.HasTrigger("TRAI:dbo.employ_Audit");
                    tb.HasTrigger("TRAIU:dbo.employ.recnum:ReservationHost");
                    tb.HasTrigger("TRAU:dbo.employ:timestamping");
                    tb.HasTrigger("TRAU:dbo.employ_Audit");
                });

            entity.HasIndex(e => e.Addrs1, "IX:employ.addrs1").HasFillFactor(80);

            entity.HasIndex(e => e.Cllphn, "IX:employ.cllphn").HasFillFactor(80);

            entity.HasIndex(e => e.Ctynme, "IX:employ.ctynme").HasFillFactor(80);

            entity.HasIndex(e => e.EMail, "IX:employ.e_mail").HasFillFactor(80);

            entity.HasIndex(e => e.Eqpnum, "IX:employ.eqpnum").HasFillFactor(80);

            entity.HasIndex(e => e.Faxnum, "IX:employ.faxnum").HasFillFactor(80);

            entity.HasIndex(e => e.Fstnme, "IX:employ.fstnme").HasFillFactor(80);

            entity.HasIndex(e => e.Homnum, "IX:employ.homnum").HasFillFactor(80);

            entity.HasIndex(e => e.Lstnme, "IX:employ.lstnme").HasFillFactor(80);

            entity.HasIndex(e => e.Pagnum, "IX:employ.pagnum").HasFillFactor(80);

            entity.HasIndex(e => e.Phnnum, "IX:employ.phnnum").HasFillFactor(80);

            entity.HasIndex(e => e.Recnum, "IX:employ.recnum")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.Uninum, "IX:employ.uninum").HasFillFactor(80);

            entity.HasIndex(e => e.Usrdf1, "IX:employ.usrdf1").HasFillFactor(80);

            entity.HasIndex(e => e.Usrdf2, "IX:employ.usrdf2").HasFillFactor(80);

            entity.HasIndex(e => e.Zipcde, "IX:employ.zipcde").HasFillFactor(80);

            entity.Property(e => e.Idnum)
                .ValueGeneratedNever()
                .HasColumnName("_idnum");
            entity.Property(e => e.Acaelc).HasColumnName("acaelc");
            entity.Property(e => e.Accsck)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("accsck");
            entity.Property(e => e.Accvac)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("accvac");
            entity.Property(e => e.Actnm2)
                .HasMaxLength(64)
                .HasDefaultValueSql("('')")
                .HasColumnName("actnm2");
            entity.Property(e => e.Actnm3)
                .HasMaxLength(64)
                .HasDefaultValueSql("('')")
                .HasColumnName("actnm3");
            entity.Property(e => e.Actnm4)
                .HasMaxLength(64)
                .HasDefaultValueSql("('')")
                .HasColumnName("actnm4");
            entity.Property(e => e.Actnum)
                .HasMaxLength(64)
                .HasDefaultValueSql("('')")
                .HasColumnName("actnum");
            entity.Property(e => e.Acttp2).HasColumnName("acttp2");
            entity.Property(e => e.Acttp3).HasColumnName("acttp3");
            entity.Property(e => e.Acttp4).HasColumnName("acttp4");
            entity.Property(e => e.Acttyp).HasColumnName("acttyp");
            entity.Property(e => e.Addrs1)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("addrs1");
            entity.Property(e => e.Addrs2)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("addrs2");
            entity.Property(e => e.Addtax)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("addtax");
            entity.Property(e => e.Admacs).HasColumnName("admacs");
            entity.Property(e => e.Advdue)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("advdue");
            entity.Property(e => e.Cllphn)
                .HasMaxLength(14)
                .HasDefaultValueSql("('')")
                .HasColumnName("cllphn");
            entity.Property(e => e.Comisn)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("comisn");
            entity.Property(e => e.Crtrpt).HasColumnName("crtrpt");
            entity.Property(e => e.Ctynme)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("ctynme");
            entity.Property(e => e.Depamt)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("depamt");
            entity.Property(e => e.Dirdep).HasColumnName("dirdep");
            entity.Property(e => e.Dp2amt)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("dp2amt");
            entity.Property(e => e.Dp3amt)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("dp3amt");
            entity.Property(e => e.Dp4amt)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("dp4amt");
            entity.Property(e => e.Dtebth)
                .HasColumnType("date")
                .HasColumnName("dtebth");
            entity.Property(e => e.Dtehre)
                .HasColumnType("date")
                .HasColumnName("dtehre");
            entity.Property(e => e.Dteina)
                .HasColumnType("date")
                .HasColumnName("dteina");
            entity.Property(e => e.EMail)
                .HasMaxLength(75)
                .HasDefaultValueSql("('')")
                .HasColumnName("e_mail");
            entity.Property(e => e.Eeoprx).HasColumnName("eeoprx");
            entity.Property(e => e.Eftac2)
                .HasMaxLength(44)
                .HasDefaultValueSql("('')")
                .HasColumnName("eftac2");
            entity.Property(e => e.Eftac3)
                .HasMaxLength(44)
                .HasDefaultValueSql("('')")
                .HasColumnName("eftac3");
            entity.Property(e => e.Eftac4)
                .HasMaxLength(44)
                .HasDefaultValueSql("('')")
                .HasColumnName("eftac4");
            entity.Property(e => e.Eftact)
                .HasMaxLength(44)
                .HasDefaultValueSql("('')")
                .HasColumnName("eftact");
            entity.Property(e => e.Eftid2)
                .HasMaxLength(3)
                .HasDefaultValueSql("('')")
                .HasColumnName("eftid2");
            entity.Property(e => e.Eftid3)
                .HasMaxLength(3)
                .HasDefaultValueSql("('')")
                .HasColumnName("eftid3");
            entity.Property(e => e.Eftid4)
                .HasMaxLength(3)
                .HasDefaultValueSql("('')")
                .HasColumnName("eftid4");
            entity.Property(e => e.Eftiid)
                .HasMaxLength(3)
                .HasDefaultValueSql("('')")
                .HasColumnName("eftiid");
            entity.Property(e => e.Eftrt2)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasColumnName("eftrt2");
            entity.Property(e => e.Eftrt3)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasColumnName("eftrt3");
            entity.Property(e => e.Eftrt4)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasColumnName("eftrt4");
            entity.Property(e => e.Eftrtn)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasColumnName("eftrtn");
            entity.Property(e => e.Eftst2).HasColumnName("eftst2");
            entity.Property(e => e.Eftst3).HasColumnName("eftst3");
            entity.Property(e => e.Eftst4).HasColumnName("eftst4");
            entity.Property(e => e.Eftsts).HasColumnName("eftsts");
            entity.Property(e => e.Empcmp).HasColumnName("empcmp");
            entity.Property(e => e.Emptyp).HasColumnName("emptyp");
            entity.Property(e => e.Eqpnum).HasColumnName("eqpnum");
            entity.Property(e => e.Exmovr).HasColumnName("exmovr");
            entity.Property(e => e.Faxnum)
                .HasMaxLength(14)
                .HasDefaultValueSql("('')")
                .HasColumnName("faxnum");
            entity.Property(e => e.Fdsklm)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("fdsklm");
            entity.Property(e => e.Fdskrt)
                .HasColumnType("decimal(10, 5)")
                .HasColumnName("fdskrt");
            entity.Property(e => e.Fdsktd)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("fdsktd");
            entity.Property(e => e.Fstnme)
                .HasMaxLength(50)
                .HasColumnName("fstnme");
            entity.Property(e => e.Fstwrk)
                .HasColumnType("date")
                .HasColumnName("fstwrk");
            entity.Property(e => e.Fulfst)
                .HasMaxLength(105)
                .HasDefaultValueSql("('')")
                .HasColumnName("fulfst");
            entity.Property(e => e.Fullst)
                .HasMaxLength(105)
                .HasDefaultValueSql("('')")
                .HasColumnName("fullst");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.Hertge).HasColumnName("hertge");
            entity.Property(e => e.Hiract).HasColumnName("hiract");
            entity.Property(e => e.Homnum)
                .HasMaxLength(14)
                .HasDefaultValueSql("('')")
                .HasColumnName("homnum");
            entity.Property(e => e.Htglst).HasColumnName("htglst");
            entity.Property(e => e.I9verf).HasColumnName("i9verf");
            entity.Property(e => e.Imgfle)
                .HasDefaultValueSql("('')")
                .HasColumnName("imgfle");
            entity.Property(e => e.Inactv).HasColumnName("inactv");
            entity.Property(e => e.Insdte)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("insdte");
            entity.Property(e => e.Insusr)
                .HasMaxLength(128)
                .HasDefaultValueSql("(original_login())")
                .HasColumnName("insusr");
            entity.Property(e => e.Lbspfn)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("lbspfn");
            entity.Property(e => e.Loctax).HasColumnName("loctax");
            entity.Property(e => e.Locwrk).HasColumnName("locwrk");
            entity.Property(e => e.Lstnme)
                .HasMaxLength(50)
                .HasColumnName("lstnme");
            entity.Property(e => e.Lstroe)
                .HasColumnType("date")
                .HasColumnName("lstroe");
            entity.Property(e => e.Lstrse)
                .HasColumnType("date")
                .HasColumnName("lstrse");
            entity.Property(e => e.Midini)
                .HasMaxLength(1)
                .HasDefaultValueSql("('')")
                .HasColumnName("midini");
            entity.Property(e => e.Mrtsts).HasColumnName("mrtsts");
            entity.Property(e => e.Ncknme)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("ncknme");
            entity.Property(e => e.Ntetxt)
                .HasDefaultValueSql("('')")
                .HasColumnName("ntetxt");
            entity.Property(e => e.Nthzne)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("nthzne");
            entity.Property(e => e.Othded)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("othded");
            entity.Property(e => e.Pagnum)
                .HasMaxLength(14)
                .HasDefaultValueSql("('')")
                .HasColumnName("pagnum");
            entity.Property(e => e.Paycls).HasColumnName("paycls");
            entity.Property(e => e.Paygrp).HasColumnName("paygrp");
            entity.Property(e => e.Payprd).HasColumnName("payprd");
            entity.Property(e => e.Paypst).HasColumnName("paypst");
            entity.Property(e => e.Payrt1)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("payrt1");
            entity.Property(e => e.Payrt2)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("payrt2");
            entity.Property(e => e.Payrt3)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("payrt3");
            entity.Property(e => e.Phnnum)
                .HasMaxLength(14)
                .HasDefaultValueSql("('')")
                .HasColumnName("phnnum");
            entity.Property(e => e.Prent2).HasColumnName("prent2");
            entity.Property(e => e.Prent3).HasColumnName("prent3");
            entity.Property(e => e.Prent4).HasColumnName("prent4");
            entity.Property(e => e.Prente).HasColumnName("prente");
            entity.Property(e => e.Pyreml)
                .HasMaxLength(75)
                .HasDefaultValueSql("('')")
                .HasColumnName("pyreml");
            entity.Property(e => e.Qt1fic)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("qt1fic");
            entity.Property(e => e.Qt1grs)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("qt1grs");
            entity.Property(e => e.Qt1med)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("qt1med");
            entity.Property(e => e.Qt2fic)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("qt2fic");
            entity.Property(e => e.Qt2grs)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("qt2grs");
            entity.Property(e => e.Qt2med)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("qt2med");
            entity.Property(e => e.Qt3fic)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("qt3fic");
            entity.Property(e => e.Qt3grs)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("qt3grs");
            entity.Property(e => e.Qt3med)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("qt3med");
            entity.Property(e => e.Qt4fic)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("qt4fic");
            entity.Property(e => e.Qt4grs)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("qt4grs");
            entity.Property(e => e.Qt4med)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("qt4med");
            entity.Property(e => e.Recnum).HasColumnName("recnum");
            entity.Property(e => e.Retchk).HasColumnName("retchk");
            entity.Property(e => e.Rtetp2).HasColumnName("rtetp2");
            entity.Property(e => e.Rtetp3).HasColumnName("rtetp3");
            entity.Property(e => e.Rtetp4).HasColumnName("rtetp4");
            entity.Property(e => e.Rtetyp).HasColumnName("rtetyp");
            entity.Property(e => e.Rtnmb2)
                .HasMaxLength(9)
                .HasDefaultValueSql("('')")
                .HasColumnName("rtnmb2");
            entity.Property(e => e.Rtnmb3)
                .HasMaxLength(9)
                .HasDefaultValueSql("('')")
                .HasColumnName("rtnmb3");
            entity.Property(e => e.Rtnmb4)
                .HasMaxLength(9)
                .HasDefaultValueSql("('')")
                .HasColumnName("rtnmb4");
            entity.Property(e => e.Rtnmbr)
                .HasMaxLength(9)
                .HasDefaultValueSql("('')")
                .HasColumnName("rtnmbr");
            entity.Property(e => e.Salary)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("salary");
            entity.Property(e => e.Sckbeg)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("sckbeg");
            entity.Property(e => e.Sckchk).HasColumnName("sckchk");
            entity.Property(e => e.Scklmt)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("scklmt");
            entity.Property(e => e.Sckmax)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("sckmax");
            entity.Property(e => e.Sckmth).HasColumnName("sckmth");
            entity.Property(e => e.Sckrte)
                .HasColumnType("decimal(10, 5)")
                .HasColumnName("sckrte");
            entity.Property(e => e.Sckytd)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("sckytd");
            entity.Property(e => e.Soccde).HasColumnName("soccde");
            entity.Property(e => e.Socsec)
                .HasMaxLength(44)
                .HasDefaultValueSql("('')")
                .HasColumnName("socsec");
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasColumnName("state_");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Taxste)
                .HasMaxLength(2)
                .HasColumnName("taxste");
            entity.Property(e => e.Uninum).HasColumnName("uninum");
            entity.Property(e => e.Upddte)
                .HasColumnType("datetime")
                .HasColumnName("upddte");
            entity.Property(e => e.Updusr)
                .HasMaxLength(128)
                .HasColumnName("updusr");
            entity.Property(e => e.Usrdf1)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("usrdf1");
            entity.Property(e => e.Usrdf2)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("usrdf2");
            entity.Property(e => e.Vacbeg)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("vacbeg");
            entity.Property(e => e.Vacdue)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("vacdue");
            entity.Property(e => e.Vaclmt)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("vaclmt");
            entity.Property(e => e.Vacmax)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("vacmax");
            entity.Property(e => e.Vacmth).HasColumnName("vacmth");
            entity.Property(e => e.Vacrte)
                .HasColumnType("decimal(10, 5)")
                .HasColumnName("vacrte");
            entity.Property(e => e.Vacytd)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("vacytd");
            entity.Property(e => e.W2elc).HasColumnName("w_2elc");
            entity.Property(e => e.W41C).HasColumnName("w4_1_c");
            entity.Property(e => e.W42C).HasColumnName("w4_2_c");
            entity.Property(e => e.W43)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("w4_3__");
            entity.Property(e => e.W44A)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("w4_4_a");
            entity.Property(e => e.W44B)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("w4_4_b");
            entity.Property(e => e.W44C)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("w4_4_c");
            entity.Property(e => e.W4Dte)
                .HasColumnType("date")
                .HasColumnName("w4_dte");
            entity.Property(e => e.Wrkcmp).HasColumnName("wrkcmp");
            entity.Property(e => e.Zipcde)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasColumnName("zipcde");

            entity.HasOne(d => d.PaygrpNavigation).WithMany(p => p.Employs)
                .HasPrincipalKey(p => p.Recnum)
                .HasForeignKey(d => d.Paygrp)
                .HasConstraintName("FK:employ.paygrp");

            entity.HasOne(d => d.UninumNavigation).WithMany(p => p.Employs)
                .HasPrincipalKey(p => p.Recnum)
                .HasForeignKey(d => d.Uninum)
                .HasConstraintName("FK:employ.uninum");

            entity.HasOne(d => d.WrkcmpNavigation).WithMany(p => p.Employs)
                .HasPrincipalKey(p => p.Recnum)
                .HasForeignKey(d => d.Wrkcmp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK:employ.wrkcmp");
        });

        modelBuilder.Entity<JobCost>(entity =>
        {
            entity.HasKey(e => e.Idnum).HasName("PK__jobcst__B47103361671BBF7");

            entity.ToTable("jobcst", tb =>
                {
                    tb.HasTrigger("TRAD:dbo.jobcst_Audit");
                    tb.HasTrigger("TRAI:dbo.jobcst_Audit");
                    tb.HasTrigger("TRAU:dbo.jobcst:timestamping");
                    tb.HasTrigger("TRAU:dbo.jobcst_Audit");
                });

            entity.HasIndex(e => e.Acrinv, "IX:jobcst.acrinv").HasFillFactor(80);

            entity.HasIndex(e => e.Active, "IX:jobcst.active").HasFillFactor(80);

            entity.HasIndex(e => e.Cstcde, "IX:jobcst.cstcde").HasFillFactor(80);

            entity.HasIndex(e => e.Dscrpt, "IX:jobcst.dscrpt").HasFillFactor(80);

            entity.HasIndex(e => e.Jobnum, "IX:jobcst.jobnum").HasFillFactor(80);

            entity.HasIndex(e => e.Lgrrec, "IX:jobcst.lgrrec").HasFillFactor(80);

            entity.HasIndex(e => e.Payrec, "IX:jobcst.payrec").HasFillFactor(80);

            entity.HasIndex(e => e.Recnum, "IX:jobcst.recnum")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.Srcnum, "IX:jobcst.srcnum").HasFillFactor(80);

            entity.HasIndex(e => e.Trnnum, "IX:jobcst.trnnum").HasFillFactor(80);

            entity.HasIndex(e => e.Usrnme, "IX:jobcst.usrnme").HasFillFactor(80);

            entity.HasIndex(e => e.Wrkord, "IX:jobcst.wrkord").HasFillFactor(80);

            entity.Property(e => e.Idnum)
                .ValueGeneratedNever()
                .HasColumnName("_idnum");
            entity.Property(e => e.Acrinv).HasColumnName("acrinv");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Actprd).HasColumnName("actprd");
            entity.Property(e => e.Blgamt)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("blgamt");
            entity.Property(e => e.Blgqty)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("blgqty");
            entity.Property(e => e.Blgttl)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("blgttl");
            entity.Property(e => e.Blgunt).HasColumnName("blgunt");
            entity.Property(e => e.Bllsts).HasColumnName("bllsts");
            entity.Property(e => e.Cstamt)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("cstamt");
            entity.Property(e => e.Cstcde)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("cstcde");
            entity.Property(e => e.Csthrs)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("csthrs");
            entity.Property(e => e.Csttyp).HasColumnName("csttyp");
            entity.Property(e => e.Dscrpt)
                .HasMaxLength(50)
                .HasColumnName("dscrpt");
            entity.Property(e => e.Empnum).HasColumnName("empnum");
            entity.Property(e => e.Entdte)
                .HasColumnType("date")
                .HasColumnName("entdte");
            entity.Property(e => e.Eqpnum).HasColumnName("eqpnum");
            entity.Property(e => e.Eqpqty)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("eqpqty");
            entity.Property(e => e.Eqptyp).HasColumnName("eqptyp");
            entity.Property(e => e.Eqpunt).HasColumnName("eqpunt");
            entity.Property(e => e.Grswge)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("grswge");
            entity.Property(e => e.Insdte)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("insdte");
            entity.Property(e => e.Insusr)
                .HasMaxLength(128)
                .HasDefaultValueSql("(original_login())")
                .HasColumnName("insusr");
            entity.Property(e => e.Jobnum).HasColumnName("jobnum");
            entity.Property(e => e.Lgrrec).HasColumnName("lgrrec");
            entity.Property(e => e.Ntetxt)
                .HasDefaultValueSql("('')")
                .HasColumnName("ntetxt");
            entity.Property(e => e.Ovhamt)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ovhamt");
            entity.Property(e => e.Ovrrde).HasColumnName("ovrrde");
            entity.Property(e => e.Payrec).HasColumnName("payrec");
            entity.Property(e => e.Paytyp).HasColumnName("paytyp");
            entity.Property(e => e.Pftamt)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("pftamt");
            entity.Property(e => e.Phsnum).HasColumnName("phsnum");
            entity.Property(e => e.Pieces)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("pieces");
            entity.Property(e => e.Postyr).HasColumnName("postyr");
            entity.Property(e => e.Recnum)
                .ValueGeneratedOnAdd()
                .HasColumnName("recnum");
            entity.Property(e => e.Shwamt)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("shwamt");
            entity.Property(e => e.Srcnum).HasColumnName("srcnum");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Taxabl).HasColumnName("taxabl");
            entity.Property(e => e.Trndte)
                .HasColumnType("date")
                .HasColumnName("trndte");
            entity.Property(e => e.Trnnum)
                .HasMaxLength(20)
                .HasColumnName("trnnum");
            entity.Property(e => e.Upddte)
                .HasColumnType("datetime")
                .HasColumnName("upddte");
            entity.Property(e => e.Updusr)
                .HasMaxLength(128)
                .HasColumnName("updusr");
            entity.Property(e => e.Usrnme)
                .HasMaxLength(128)
                .HasDefaultValueSql("('')")
                .HasColumnName("usrnme");
            entity.Property(e => e.Vndnum).HasColumnName("vndnum");
            entity.Property(e => e.Wrkord)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasColumnName("wrkord");

            entity.HasOne(d => d.EmpnumNavigation).WithMany(p => p.Jobcsts)
                .HasPrincipalKey(p => p.Recnum)
                .HasForeignKey(d => d.Empnum)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK:jobcst.empnum_SetNull");

            entity.HasOne(d => d.PayrecNavigation).WithMany(p => p.Jobcsts)
                .HasPrincipalKey(p => p.Recnum)
                .HasForeignKey(d => d.Payrec)
                .HasConstraintName("FK:jobcst.payrec");
        });

        modelBuilder.Entity<LedgerAccount>(entity =>
        {
            entity.HasKey(e => e.Idnum).HasName("PK__lgract__B4710336F3E84032");

            entity.ToTable("lgract", tb =>
                {
                    tb.HasTrigger("TRAD:dbo.lgract_Audit");
                    tb.HasTrigger("TRAI:dbo.lgract_Audit");
                    tb.HasTrigger("TRAIU:dbo.lgract.recnum:ReservationHost");
                    tb.HasTrigger("TRAU:dbo.lgract:timestamping");
                    tb.HasTrigger("TRAU:dbo.lgract_Audit");
                });

            entity.HasIndex(e => e.Lngnme, "IX:lgract.lngnme").HasFillFactor(80);

            entity.HasIndex(e => e.Recnum, "IX:lgract.recnum")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.Shtnme, "IX:lgract.shtnme").HasFillFactor(80);

            entity.HasIndex(e => e.Sumact, "IX:lgract.sumact").HasFillFactor(80);

            entity.Property(e => e.Idnum)
                .ValueGeneratedNever()
                .HasColumnName("_idnum");
            entity.Property(e => e.Acttyp).HasColumnName("acttyp");
            entity.Property(e => e.Begbal)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("begbal");
            entity.Property(e => e.BnkId)
                .HasMaxLength(36)
                .HasDefaultValueSql("('')")
                .HasColumnName("bnk_id");
            entity.Property(e => e.Csttyp).HasColumnName("csttyp");
            entity.Property(e => e.Dbtcrd).HasColumnName("dbtcrd");
            entity.Property(e => e.Endbal)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("endbal");
            entity.Property(e => e.Inactv).HasColumnName("inactv");
            entity.Property(e => e.Insdte)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("insdte");
            entity.Property(e => e.Insusr)
                .HasMaxLength(128)
                .HasDefaultValueSql("(original_login())")
                .HasColumnName("insusr");
            entity.Property(e => e.Iscrcd).HasColumnName("iscrcd");
            entity.Property(e => e.Jobsub).HasColumnName("jobsub");
            entity.Property(e => e.Lngnme)
                .HasMaxLength(50)
                .HasColumnName("lngnme");
            entity.Property(e => e.Ntetxt)
                .HasDefaultValueSql("('')")
                .HasColumnName("ntetxt");
            entity.Property(e => e.Nxtchk).HasColumnName("nxtchk");
            entity.Property(e => e.Nxtdep).HasColumnName("nxtdep");
            entity.Property(e => e.Recnum).HasColumnName("recnum");
            entity.Property(e => e.Shtnme)
                .HasMaxLength(30)
                .HasColumnName("shtnme");
            entity.Property(e => e.Strbal)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("strbal");
            entity.Property(e => e.Subact).HasColumnName("subact");
            entity.Property(e => e.Sumact).HasColumnName("sumact");
            entity.Property(e => e.TrnId).HasColumnName("trn_id");
            entity.Property(e => e.Upddte)
                .HasColumnType("datetime")
                .HasColumnName("upddte");
            entity.Property(e => e.Updusr)
                .HasMaxLength(128)
                .HasColumnName("updusr");

            entity.HasOne(d => d.SumactNavigation).WithMany(p => p.InverseSumactNavigation)
                .HasPrincipalKey(p => p.Recnum)
                .HasForeignKey(d => d.Sumact)
                .HasConstraintName("FK:lgract.sumact");
        });

        modelBuilder.Entity<LedgerBalance>(entity =>
        {
            entity.HasKey(e => e.Idnum).HasName("PK__lgrbal__B4710336F7167E8A");

            entity.ToTable("lgrbal", tb =>
                {
                    tb.HasTrigger("TRAD:dbo.lgrbal_Audit");
                    tb.HasTrigger("TRAI:dbo.lgrbal_Audit");
                    tb.HasTrigger("TRAU:dbo.lgrbal:timestamping");
                    tb.HasTrigger("TRAU:dbo.lgrbal_Audit");
                });

            entity.HasIndex(e => e.Actprd, "IX:lgrbal.actprd").HasFillFactor(80);

            entity.HasIndex(e => e.Lgract, "IX:lgrbal.lgract").HasFillFactor(80);

            entity.HasIndex(e => e.Postyr, "IX:lgrbal.postyr").HasFillFactor(80);

            entity.HasIndex(e => e.Recnum, "IX:lgrbal.recnum")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Idnum)
                .ValueGeneratedNever()
                .HasColumnName("_idnum");
            entity.Property(e => e.Actprd).HasColumnName("actprd");
            entity.Property(e => e.Balnce)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("balnce");
            entity.Property(e => e.Budget)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("budget");
            entity.Property(e => e.Idref).HasColumnName("_idref");
            entity.Property(e => e.Insdte)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("insdte");
            entity.Property(e => e.Insusr)
                .HasMaxLength(128)
                .HasDefaultValueSql("(original_login())")
                .HasColumnName("insusr");
            entity.Property(e => e.Lgract).HasColumnName("lgract");
            entity.Property(e => e.Postyr).HasColumnName("postyr");
            entity.Property(e => e.Recnum)
                .ValueGeneratedOnAdd()
                .HasColumnName("recnum");
            entity.Property(e => e.Upddte)
                .HasColumnType("datetime")
                .HasColumnName("upddte");
            entity.Property(e => e.Updusr)
                .HasMaxLength(128)
                .HasColumnName("updusr");

            entity.HasOne(d => d.IdrefNavigation).WithMany(p => p.LgrbalIdrefNavigations)
                .HasForeignKey(d => d.Idref)
                .HasConstraintName("FK:lgrbal._idref_Cascade");

            entity.HasOne(d => d.LedgerAccountNavigation).WithMany(p => p.LgrbalLgractNavigations)
                .HasPrincipalKey(p => p.Recnum)
                .HasForeignKey(d => d.Lgract)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK:lgrbal.lgract");
        });

        modelBuilder.Entity<PayGroup>(entity =>
        {
            entity.HasKey(e => e.Idnum).HasName("PK__paygrp__B47103364BCEAB98");

            entity.ToTable("paygrp", tb =>
                {
                    tb.HasTrigger("TRAD:dbo.paygrp_Audit");
                    tb.HasTrigger("TRAI:dbo.paygrp_Audit");
                    tb.HasTrigger("TRAU:dbo.paygrp:timestamping");
                    tb.HasTrigger("TRAU:dbo.paygrp_Audit");
                });

            entity.HasIndex(e => e.Grpnme, "IX:paygrp.grpnme").HasFillFactor(80);

            entity.HasIndex(e => e.Recnum, "IX:paygrp.recnum")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.Uninum, "IX:paygrp.uninum").HasFillFactor(80);

            entity.Property(e => e.Idnum)
                .ValueGeneratedNever()
                .HasColumnName("_idnum");
            entity.Property(e => e.Clscde)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasColumnName("clscde");
            entity.Property(e => e.Clslvl).HasColumnName("clslvl");
            entity.Property(e => e.Clsprc)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("clsprc");
            entity.Property(e => e.Grpnme)
                .HasMaxLength(50)
                .HasColumnName("grpnme");
            entity.Property(e => e.Inactv)
                .HasMaxLength(1)
                .HasDefaultValueSql("('')")
                .HasColumnName("inactv");
            entity.Property(e => e.Insdte)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("insdte");
            entity.Property(e => e.Insusr)
                .HasMaxLength(128)
                .HasDefaultValueSql("(original_login())")
                .HasColumnName("insusr");
            entity.Property(e => e.Ntetxt)
                .HasDefaultValueSql("('')")
                .HasColumnName("ntetxt");
            entity.Property(e => e.Ovrrde)
                .HasMaxLength(1)
                .HasDefaultValueSql("('')")
                .HasColumnName("ovrrde");
            entity.Property(e => e.Payrt1)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("payrt1");
            entity.Property(e => e.Payrt2)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("payrt2");
            entity.Property(e => e.Payrt3)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("payrt3");
            entity.Property(e => e.Pcerte)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("pcerte");
            entity.Property(e => e.Recnum).HasColumnName("recnum");
            entity.Property(e => e.Uninum).HasColumnName("uninum");
            entity.Property(e => e.Upddte)
                .HasColumnType("datetime")
                .HasColumnName("upddte");
            entity.Property(e => e.Updusr)
                .HasMaxLength(128)
                .HasColumnName("updusr");
            entity.Property(e => e.Wrkcls)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("wrkcls");

            entity.HasOne(d => d.UninumNavigation).WithMany(p => p.Paygrps)
                .HasPrincipalKey(p => p.Recnum)
                .HasForeignKey(d => d.Uninum)
                .HasConstraintName("FK:paygrp.uninum");
        });

        modelBuilder.Entity<PayrollRecord>(entity =>
        {
            entity.HasKey(e => e.Idnum).HasName("PK__payrec__B471033620BF0D9A");

            entity.ToTable("payrec", tb =>
                {
                    tb.HasTrigger("TRAD:dbo.payrec_Audit");
                    tb.HasTrigger("TRAI:dbo.payrec_Audit");
                    tb.HasTrigger("TRAU:dbo.payrec:timestamping");
                    tb.HasTrigger("TRAU:dbo.payrec_Audit");
                });

            entity.HasIndex(e => e.Chkdte, "IX:payrec.chkdte").HasFillFactor(80);

            entity.HasIndex(e => e.Chknum, "IX:payrec.chknum").HasFillFactor(80);

            entity.HasIndex(e => e.Empnum, "IX:payrec.empnum").HasFillFactor(80);

            entity.HasIndex(e => e.Lgrrec, "IX:payrec.lgrrec").HasFillFactor(80);

            entity.HasIndex(e => e.Payprd, "IX:payrec.payprd").HasFillFactor(80);

            entity.HasIndex(e => e.Recnum, "IX:payrec.recnum")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.Strprd, "IX:payrec.strprd").HasFillFactor(80);

            entity.HasIndex(e => e.Usrnme, "IX:payrec.usrnme").HasFillFactor(80);

            entity.Property(e => e.Idnum)
                .ValueGeneratedNever()
                .HasColumnName("_idnum");
            entity.Property(e => e.Acahr1)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("acahr1");
            entity.Property(e => e.Acahr2)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("acahr2");
            entity.Property(e => e.Acaovr).HasColumnName("acaovr");
            entity.Property(e => e.Accsck)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("accsck");
            entity.Property(e => e.Accvac)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("accvac");
            entity.Property(e => e.Addttl)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("addttl");
            entity.Property(e => e.Advnce)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("advnce");
            entity.Property(e => e.Chkdte)
                .HasColumnType("date")
                .HasColumnName("chkdte");
            entity.Property(e => e.Chknum)
                .HasMaxLength(20)
                .HasColumnName("chknum");
            entity.Property(e => e.Cmpgrs)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("cmpgrs");
            entity.Property(e => e.Cmpwge)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("cmpwge");
            entity.Property(e => e.Ddpbch).HasColumnName("ddpbch");
            entity.Property(e => e.Dedttl)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("dedttl");
            entity.Property(e => e.Dirdep).HasColumnName("dirdep");
            entity.Property(e => e.Empnum).HasColumnName("empnum");
            entity.Property(e => e.Entdte)
                .HasColumnType("date")
                .HasColumnName("entdte");
            entity.Property(e => e.Fedsck)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("fedsck");
            entity.Property(e => e.Grspay)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("grspay");
            entity.Property(e => e.Holhrs)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("holhrs");
            entity.Property(e => e.Holpay)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("holpay");
            entity.Property(e => e.Insdte)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("insdte");
            entity.Property(e => e.Insusr)
                .HasMaxLength(128)
                .HasDefaultValueSql("(original_login())")
                .HasColumnName("insusr");
            entity.Property(e => e.Lgrrec).HasColumnName("lgrrec");
            entity.Property(e => e.Mscpay)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("mscpay");
            entity.Property(e => e.Netpay)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("netpay");
            entity.Property(e => e.Ntetxt)
                .HasDefaultValueSql("('')")
                .HasColumnName("ntetxt");
            entity.Property(e => e.Ovthrs)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("ovthrs");
            entity.Property(e => e.Ovtpay)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ovtpay");
            entity.Property(e => e.Payprd)
                .HasColumnType("date")
                .HasColumnName("payprd");
            entity.Property(e => e.Payrt1)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("payrt1");
            entity.Property(e => e.Payrt2)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("payrt2");
            entity.Property(e => e.Payrt3)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("payrt3");
            entity.Property(e => e.Paytyp).HasColumnName("paytyp");
            entity.Property(e => e.Pcerte)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("pcerte");
            entity.Property(e => e.Pcpyrt)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("pcpyrt");
            entity.Property(e => e.Perdim)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("perdim");
            entity.Property(e => e.Pieces)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("pieces");
            entity.Property(e => e.Prmhrs)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("prmhrs");
            entity.Property(e => e.Prmpay)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("prmpay");
            entity.Property(e => e.Qtrnum).HasColumnName("qtrnum");
            entity.Property(e => e.Recnum)
                .ValueGeneratedOnAdd()
                .HasColumnName("recnum");
            entity.Property(e => e.Reghrs)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("reghrs");
            entity.Property(e => e.Regpay)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("regpay");
            entity.Property(e => e.Salary)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("salary");
            entity.Property(e => e.Sckhrs)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("sckhrs");
            entity.Property(e => e.Sckpay)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("sckpay");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Stdsck)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("stdsck");
            entity.Property(e => e.Strprd)
                .HasColumnType("date")
                .HasColumnName("strprd");
            entity.Property(e => e.Taxste)
                .HasMaxLength(2)
                .HasColumnName("taxste");
            entity.Property(e => e.Ttlhrs)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("ttlhrs");
            entity.Property(e => e.Upddte)
                .HasColumnType("datetime")
                .HasColumnName("upddte");
            entity.Property(e => e.Updusr)
                .HasMaxLength(128)
                .HasColumnName("updusr");
            entity.Property(e => e.Usrnme)
                .HasMaxLength(128)
                .HasDefaultValueSql("('')")
                .HasColumnName("usrnme");
            entity.Property(e => e.Vacatn)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("vacatn");
            entity.Property(e => e.Vachrs)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("vachrs");
            entity.Property(e => e.Vacpay)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("vacpay");
            entity.Property(e => e.Ytdgrs)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ytdgrs");
            entity.Property(e => e.Ytdnet)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ytdnet");

            entity.HasOne(d => d.EmpnumNavigation).WithMany(p => p.Payrecs)
                .HasPrincipalKey(p => p.Recnum)
                .HasForeignKey(d => d.Empnum)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK:payrec.empnum");
        });

        modelBuilder.Entity<PayrollUnion>(entity =>
        {
            entity.HasKey(e => e.Idnum).HasName("PK__payuni__B47103365ED36392");

            entity.ToTable("payuni", tb =>
                {
                    tb.HasTrigger("TRAD:dbo.payuni_Audit");
                    tb.HasTrigger("TRAI:dbo.payuni_Audit");
                    tb.HasTrigger("TRAU:dbo.payuni:timestamping");
                    tb.HasTrigger("TRAU:dbo.payuni_Audit");
                });

            entity.HasIndex(e => e.Recnum, "IX:payuni.recnum")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.Uninme, "IX:payuni.uninme").HasFillFactor(80);

            entity.Property(e => e.Idnum)
                .ValueGeneratedNever()
                .HasColumnName("_idnum");
            entity.Property(e => e.Addrs1)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("addrs1");
            entity.Property(e => e.Addrs2)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("addrs2");
            entity.Property(e => e.Ctynme)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("ctynme");
            entity.Property(e => e.Insdte)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("insdte");
            entity.Property(e => e.Insusr)
                .HasMaxLength(128)
                .HasDefaultValueSql("(original_login())")
                .HasColumnName("insusr");
            entity.Property(e => e.Phnnum)
                .HasMaxLength(14)
                .HasDefaultValueSql("('')")
                .HasColumnName("phnnum");
            entity.Property(e => e.Recnum).HasColumnName("recnum");
            entity.Property(e => e.Rppact).HasColumnName("rppact");
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasColumnName("state_");
            entity.Property(e => e.Uninme)
                .HasMaxLength(50)
                .HasColumnName("uninme");
            entity.Property(e => e.Upddte)
                .HasColumnType("datetime")
                .HasColumnName("upddte");
            entity.Property(e => e.Updusr)
                .HasMaxLength(128)
                .HasColumnName("updusr");
            entity.Property(e => e.Zipcde)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasColumnName("zipcde");
        });

        modelBuilder.Entity<WorkersComp>(entity =>
        {
            entity.HasKey(e => e.Idnum).HasName("PK__wkrcmp__B4710336949124DD");

            entity.ToTable("wkrcmp", tb =>
                {
                    tb.HasTrigger("TRAD:dbo.wkrcmp_Audit");
                    tb.HasTrigger("TRAI:dbo.wkrcmp_Audit");
                    tb.HasTrigger("TRAU:dbo.wkrcmp:timestamping");
                    tb.HasTrigger("TRAU:dbo.wkrcmp_Audit");
                });

            entity.HasIndex(e => e.Cdenme, "IX:wkrcmp.cdenme").HasFillFactor(80);

            entity.HasIndex(e => e.Recnum, "IX:wkrcmp.recnum")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.Taxste, "IX:wkrcmp.taxste").HasFillFactor(80);

            entity.Property(e => e.Idnum)
                .ValueGeneratedNever()
                .HasColumnName("_idnum");
            entity.Property(e => e.Addmod)
                .HasColumnType("decimal(9, 6)")
                .HasColumnName("addmod");
            entity.Property(e => e.Cdenme)
                .HasMaxLength(50)
                .HasColumnName("cdenme");
            entity.Property(e => e.Emehrs)
                .HasColumnType("decimal(8, 5)")
                .HasColumnName("emehrs");
            entity.Property(e => e.Emrhrs)
                .HasColumnType("decimal(8, 5)")
                .HasColumnName("emrhrs");
            entity.Property(e => e.Expmod)
                .HasColumnType("decimal(9, 6)")
                .HasColumnName("expmod");
            entity.Property(e => e.Inactv)
                .HasMaxLength(1)
                .HasDefaultValueSql("('')")
                .HasColumnName("inactv");
            entity.Property(e => e.Insdte)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("insdte");
            entity.Property(e => e.Insusr)
                .HasMaxLength(128)
                .HasDefaultValueSql("(original_login())")
                .HasColumnName("insusr");
            entity.Property(e => e.Libins)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("libins");
            entity.Property(e => e.Maxwge)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("maxwge");
            entity.Property(e => e.Ntetxt)
                .HasDefaultValueSql("('')")
                .HasColumnName("ntetxt");
            entity.Property(e => e.Pctrte)
                .HasColumnType("decimal(8, 4)")
                .HasColumnName("pctrte");
            entity.Property(e => e.Recnum).HasColumnName("recnum");
            entity.Property(e => e.Taxste)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasColumnName("taxste");
            entity.Property(e => e.Upddte)
                .HasColumnType("datetime")
                .HasColumnName("upddte");
            entity.Property(e => e.Updusr)
                .HasMaxLength(128)
                .HasColumnName("updusr");
        });
        modelBuilder.HasSequence("LedgerRefSequence")
            .StartsAt(3751L)
            .HasMin(1L);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
