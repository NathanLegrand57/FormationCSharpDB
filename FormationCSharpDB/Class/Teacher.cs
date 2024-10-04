using System;
using System.Collections.Generic;

namespace FormationCSharpDB.Class;

public partial class Teacher
{
    public int Id { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Subject { get; set; } = null!;
}
