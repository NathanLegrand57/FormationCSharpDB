using System;
using System.Collections.Generic;

namespace FormationCSharpDB.Class;

public partial class School
{
    public int Id { get; set; }

    public string SchoolName { get; set; } = null!;

    public bool State { get; set; }

    public int NumberOfStudents { get; set; }
}
