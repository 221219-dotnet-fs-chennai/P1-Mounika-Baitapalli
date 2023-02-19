using System;
using System.Collections.Generic;

namespace DataFluentApi.Entities;

public partial class CompanyDetail
{
    public int UserId { get; set; }

    public string? CompanyName { get; set; }

    public string? ExperienceInYears { get; set; }

    public string? Position { get; set; }

    public virtual TrainerDetail User { get; set; } = null!;
}
