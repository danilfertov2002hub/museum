using System;
using System.Collections.Generic;

namespace museum;

public partial class Postt
{
    public int IdPost { get; set; }

    public string NamePost { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
}
