using System;
using System.Collections.Generic;

namespace museum;

public partial class Passport
{
    public int IdPassport { get; set; }

    public string Number { get; set; } = null!;

    public string Series { get; set; } = null!;

    public string CodeDivision { get; set; } = null!;

    public DateTime DateOfIssue { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
}
