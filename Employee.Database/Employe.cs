using System;
using System.Collections.Generic;

namespace Employee.Database;

public partial class Employe
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;
}
