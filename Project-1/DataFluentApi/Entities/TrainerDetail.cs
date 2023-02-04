using System;
using System.Collections.Generic;

namespace DataFluentApi.Entities;

public partial class TrainerDetail
{
    public int UserId { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? EmailId { get; set; }

    public string? Password { get; set; }

    public string? ContactNumber { get; set; }

    public string? Location { get; set; }

    public string? SocialMediaProfile { get; set; }

    public virtual CompanyDetail? CompanyDetail { get; set; }

    public virtual EducationDetail? EducationDetail { get; set; }

    public virtual SkillSet? SkillSet { get; set; }
}
