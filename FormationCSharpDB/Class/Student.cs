using System;
using System.Collections.Generic;

namespace FormationCSharpDB.Class;

public partial class Student
{
    public int Id { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public int Age { get; set; }

    public string Class { get; set; } = null!;
}
