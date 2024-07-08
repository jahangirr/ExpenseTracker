using System;
using System.Collections.Generic;

namespace ExpenseTrack;

public partial class Voucher
{
    public int Id { get; set; }

    public string? BillNo { get; set; }

    public string? ChallanNo { get; set; }

    public DateTime? Tarik { get; set; }

    public int? NameId { get; set; }

    public int? ProjectId { get; set; }

    public string? Thikana { get; set; }

    public bool? IsBeton { get; set; }

    public bool? IsHeadMistry { get; set; }

    public int? MistryNum2 { get; set; }

    public int? MistryHarizaNum2 { get; set; }

    public decimal? MistryMozuri2 { get; set; }

    public decimal? MistrymotMozuri2 { get; set; }

    public int? MistryNum1 { get; set; }

    public int? MistryHarizaNum1 { get; set; }

    public decimal? MistryMozuri1 { get; set; }

    public decimal? MistrymotMozuri1 { get; set; }

    public int? HelperNum2 { get; set; }

    public int? HelperHarizaNum2 { get; set; }

    public decimal? HelperMozuri2 { get; set; }

    public decimal? HelpermotMozuri2 { get; set; }

    public int? HelperNum1 { get; set; }

    public int? HelperHarizaNum1 { get; set; }

    public decimal? HelperMozuri1 { get; set; }

    public decimal? HelpermotMozuri1 { get; set; }

    public decimal? Onnanno { get; set; }

    public decimal? Mot { get; set; }

    public string? MotInWord { get; set; }

    public DateTime? CreateTime { get; set; }

    public virtual PersonInfo? Name { get; set; }

    public virtual ProjectInfo? Project { get; set; }

    public virtual VoucherApprove? VoucherApprove { get; set; }
}
