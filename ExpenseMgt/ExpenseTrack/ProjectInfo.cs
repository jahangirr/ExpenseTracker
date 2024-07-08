using System;
using System.Collections.Generic;

namespace ExpenseTrack;

public partial class ProjectInfo
{
    public int Id { get; set; }

    public string? ProjectName { get; set; }

    public virtual ICollection<ContractorMapping> ContractorMappings { get; set; } = new List<ContractorMapping>();

    public virtual ICollection<Contractualvoucher> Contractualvouchers { get; set; } = new List<Contractualvoucher>();

    public virtual ICollection<Voucher> Vouchers { get; set; } = new List<Voucher>();
}
