using System;
using System.Collections.Generic;

namespace ExpenseTrack;

public partial class Contractualvoucher
{
    public int Id { get; set; }

    public string? BillNo { get; set; }

    public string? ChallanNo { get; set; }

    public DateTime? Tarik { get; set; }

    public int? NameId { get; set; }

    public int? ProjectId { get; set; }

    public string? Thikana { get; set; }

    public decimal? Motprappo { get; set; }

    public string? Grohonhistory { get; set; }

    public decimal? Grohon { get; set; }

    public decimal? Onnanno { get; set; }

    public decimal? Mot { get; set; }

    public string? MotInWord { get; set; }

    public DateTime? CreateTime { get; set; }

    public virtual ContractualvoucherApprove? ContractualvoucherApprove { get; set; }

    public virtual PersonInfo? Name { get; set; }

    public virtual ProjectInfo? Project { get; set; }
}
