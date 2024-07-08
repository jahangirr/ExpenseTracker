using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTrack;

public partial class ExpenseContext : DbContext
{
    public ExpenseContext()
    {
    }

    public ExpenseContext(DbContextOptions<ExpenseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ContractorMapping> ContractorMappings { get; set; }

    public virtual DbSet<Contractualvoucher> Contractualvouchers { get; set; }

    public virtual DbSet<ContractualvoucherApprove> ContractualvoucherApproves { get; set; }

    public virtual DbSet<LogingInfo> LogingInfos { get; set; }

    public virtual DbSet<PersonInfo> PersonInfos { get; set; }

    public virtual DbSet<PersonTypeInfo> PersonTypeInfos { get; set; }

    public virtual DbSet<ProjectInfo> ProjectInfos { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    public virtual DbSet<VoucherApprove> VoucherApproves { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=Expense;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ContractorMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PersonMa__3214EC070C516C2C");

            entity.ToTable("ContractorMapping");

            entity.HasIndex(e => new { e.PersonId, e.ProjectNameId }, "ContractorMapping_person_project").IsUnique();

            entity.Property(e => e.ContractualMoney).HasColumnType("decimal(12, 2)");

            entity.HasOne(d => d.Person).WithMany(p => p.ContractorMappings)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK__PersonMap__Perso__267ABA7A");

            entity.HasOne(d => d.ProjectName).WithMany(p => p.ContractorMappings)
                .HasForeignKey(d => d.ProjectNameId)
                .HasConstraintName("FK__PersonMap__Proje__36B12243");
        });

        modelBuilder.Entity<Contractualvoucher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__contract__3214EC0726C5DC34");

            entity.ToTable("contractualvoucher");

            entity.Property(e => e.BillNo)
                .HasMaxLength(50)
                .HasColumnName("billNo");
            entity.Property(e => e.ChallanNo)
                .HasMaxLength(50)
                .HasColumnName("challanNo");
            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createTime");
            entity.Property(e => e.Grohon)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("grohon");
            entity.Property(e => e.Grohonhistory).HasColumnName("grohonhistory");
            entity.Property(e => e.Mot)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("mot");
            entity.Property(e => e.MotInWord).HasColumnName("motInWord");
            entity.Property(e => e.Motprappo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("motprappo");
            entity.Property(e => e.NameId).HasColumnName("nameId");
            entity.Property(e => e.Onnanno)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("onnanno");
            entity.Property(e => e.ProjectId).HasColumnName("projectId");
            entity.Property(e => e.Tarik)
                .HasColumnType("datetime")
                .HasColumnName("tarik");
            entity.Property(e => e.Thikana).HasColumnName("thikana");

            entity.HasOne(d => d.Name).WithMany(p => p.Contractualvouchers)
                .HasForeignKey(d => d.NameId)
                .HasConstraintName("FK__contractu__nameI__531856C7");

            entity.HasOne(d => d.Project).WithMany(p => p.Contractualvouchers)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("FK__contractu__proje__540C7B00");
        });

        modelBuilder.Entity<ContractualvoucherApprove>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contract__3214EC07FB9B1936");

            entity.ToTable("ContractualvoucherApprove");

            entity.HasIndex(e => e.ContractualvoucherId, "UQ__Contract__44D9C52CE5A75987").IsUnique();

            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Contractualvoucher).WithOne(p => p.ContractualvoucherApprove)
                .HasForeignKey<ContractualvoucherApprove>(d => d.ContractualvoucherId)
                .HasConstraintName("FK__Contractu__Contr__793DFFAF");
        });

        modelBuilder.Entity<LogingInfo>(entity =>
        {
            entity.ToTable("LogingInfo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
            entity.Property(e => e.Userpassword)
                .HasMaxLength(50)
                .HasColumnName("userpassword");
        });

        modelBuilder.Entity<PersonInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PersonIn__3214EC07280E4243");

            entity.ToTable("PersonInfo");

            entity.Property(e => e.Personaddress).HasColumnName("personaddress");
            entity.Property(e => e.Personname).HasColumnName("personname");
            entity.Property(e => e.Persontype).HasColumnName("persontype");

            entity.HasOne(d => d.PersontypeNavigation).WithMany(p => p.PersonInfos)
                .HasForeignKey(d => d.Persontype)
                .HasConstraintName("FK__PersonInf__perso__01142BA1");
        });

        modelBuilder.Entity<PersonTypeInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PersonTy__3213E83F6632C7A2");

            entity.ToTable("PersonTypeInfo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PersonType).HasColumnName("personType");
        });

        modelBuilder.Entity<ProjectInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProjectI__3214EC073A54D28C");

            entity.ToTable("ProjectInfo");

            entity.Property(e => e.ProjectName).HasColumnName("projectName");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__voucher__3214EC07B86433B2");

            entity.ToTable("voucher");

            entity.Property(e => e.BillNo)
                .HasMaxLength(50)
                .HasColumnName("billNo");
            entity.Property(e => e.ChallanNo)
                .HasMaxLength(50)
                .HasColumnName("challanNo");
            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createTime");
            entity.Property(e => e.HelperHarizaNum1).HasColumnName("helperHarizaNum1");
            entity.Property(e => e.HelperHarizaNum2).HasColumnName("helperHarizaNum2");
            entity.Property(e => e.HelperMozuri1)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("helperMozuri1");
            entity.Property(e => e.HelperMozuri2)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("helperMozuri2");
            entity.Property(e => e.HelperNum1).HasColumnName("helperNum1");
            entity.Property(e => e.HelperNum2).HasColumnName("helperNum2");
            entity.Property(e => e.HelpermotMozuri1)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("helpermotMozuri1");
            entity.Property(e => e.HelpermotMozuri2)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("helpermotMozuri2");
            entity.Property(e => e.IsBeton).HasColumnName("isBeton");
            entity.Property(e => e.IsHeadMistry).HasColumnName("isHeadMistry");
            entity.Property(e => e.MistryHarizaNum1).HasColumnName("mistryHarizaNum1");
            entity.Property(e => e.MistryHarizaNum2).HasColumnName("mistryHarizaNum2");
            entity.Property(e => e.MistryMozuri1)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("mistryMozuri1");
            entity.Property(e => e.MistryMozuri2)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("mistryMozuri2");
            entity.Property(e => e.MistryNum1).HasColumnName("mistryNum1");
            entity.Property(e => e.MistryNum2).HasColumnName("mistryNum2");
            entity.Property(e => e.MistrymotMozuri1)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("mistrymotMozuri1");
            entity.Property(e => e.MistrymotMozuri2)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("mistrymotMozuri2");
            entity.Property(e => e.Mot)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("mot");
            entity.Property(e => e.MotInWord).HasColumnName("motInWord");
            entity.Property(e => e.NameId).HasColumnName("nameId");
            entity.Property(e => e.Onnanno)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("onnanno");
            entity.Property(e => e.ProjectId).HasColumnName("projectId");
            entity.Property(e => e.Tarik)
                .HasColumnType("datetime")
                .HasColumnName("tarik");
            entity.Property(e => e.Thikana).HasColumnName("thikana");

            entity.HasOne(d => d.Name).WithMany(p => p.Vouchers)
                .HasForeignKey(d => d.NameId)
                .HasConstraintName("FK__voucher__nameId__4F47C5E3");

            entity.HasOne(d => d.Project).WithMany(p => p.Vouchers)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("FK__voucher__project__503BEA1C");
        });

        modelBuilder.Entity<VoucherApprove>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__voucherA__3214EC0736A42379");

            entity.ToTable("voucherApprove");

            entity.HasIndex(e => e.VoucherId, "UQ__voucherA__3AEE7920E687FF63").IsUnique();

            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Voucher).WithOne(p => p.VoucherApprove)
                .HasForeignKey<VoucherApprove>(d => d.VoucherId)
                .HasConstraintName("FK__voucherAp__Vouch__756D6ECB");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
