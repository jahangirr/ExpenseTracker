using System;
using System.Collections.Generic;

namespace ExpenseTrack;

public partial class ContractorMapping
{
    public int Id { get; set; }

    public int? PersonId { get; set; }

    public int? ProjectNameId { get; set; }

    public decimal? ContractualMoney { get; set; }

    public virtual PersonInfo? Person { get; set; }

    public virtual ProjectInfo? ProjectName { get; set; }
}
