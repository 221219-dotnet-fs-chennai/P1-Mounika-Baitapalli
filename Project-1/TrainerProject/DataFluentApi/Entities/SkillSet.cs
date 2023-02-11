using System;
using System.Collections.Generic;

namespace DataFluentApi.Entities;

public partial class SkillSet
{
    public int UserId { get; set; }

    public string? Skill1 { get; set; }

    public string? Skill2 { get; set; }

    public string? Skill3 { get; set; }

    public virtual TrainerDetail User { get; set; } = null!;
}
