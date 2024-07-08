using System;
using System.Collections.Generic;

namespace ExpenseTrack;

public partial class AccountInfo
{
    public int Id { get; set; }

    public string? AccountName { get; set; }

    public DateTime? AccountStart { get; set; }

    public decimal? AccountTotalContact { get; set; }

    public virtual ICollection<ContractorMapping> PersonMappingAccounts { get; set; } = new List<ContractorMapping>();
}
