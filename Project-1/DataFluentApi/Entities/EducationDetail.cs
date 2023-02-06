using Models;
using System;
using System.Collections.Generic;

namespace DataFluentApi.Entities;

public partial class EducationDetail
{
    public int UserId { get; set; }

    public string? Institution { get; set; }

    public string? Degree { get; set; }

    public string? Specialization { get; set; }

    public string? YearOfPassing { get; set; }

    public virtual TrainerDetail User { get; set; } = null!;

    /*public IEnumerable<Trainer> Select(Func<EducationDetail, IEnumerable<Trainer>> edMap)
    {
        throw new NotImplementedException();
    }*/
}
