using System;
using System.Collections.Generic;

namespace ExpenseTrack;

public partial class VoucherApprove
{
    public int Id { get; set; }

    public int? VoucherId { get; set; }

    public DateTime? CreateTime { get; set; }

    public virtual Voucher? Voucher { get; set; }
}
