using System;
using System.Collections.Generic;

namespace museum;

public partial class Employee
{
    public int IdEmployee { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Secondname { get; set; } = null!;

    public int PostId { get; set; }

    public DateTime Birthday { get; set; }

    public int PassportId { get; set; }

    public virtual Passport Passport { get; set; } = null!;

    public virtual Postt Post { get; set; } = null!;
}
