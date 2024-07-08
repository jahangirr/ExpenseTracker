using System;
using System.Collections.Generic;

namespace ExpenseTrack;

public partial class PersonTypeInfo
{
    public int Id { get; set; }

    public string? PersonType { get; set; }

    public virtual ICollection<PersonInfo> PersonInfos { get; set; } = new List<PersonInfo>();
}
