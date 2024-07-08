using System;
using System.Collections.Generic;

namespace ExpenseTrack;

public partial class ContractualvoucherApprove
{
    public int Id { get; set; }

    public int? ContractualvoucherId { get; set; }

    public DateTime? CreateTime { get; set; }

    public virtual Contractualvoucher? Contractualvoucher { get; set; }
}
