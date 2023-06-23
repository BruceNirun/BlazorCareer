using System;
using System.Collections.Generic;

namespace BlazorCareer.Models;

public partial class Education
{
    public int EducationId { get; set; }

    public string? EducationLevel { get; set; }

    public string? NameOfInstitute { get; set; }

    public string? Major { get; set; }

    public double? Gpa { get; set; }

    public DateTime? EducationStart { get; set; }

    public DateTime? EducationEnd { get; set; }

    public virtual ICollection<EducationPersonalDatum> EducationPersonalData { get; set; } = new List<EducationPersonalDatum>();
}
