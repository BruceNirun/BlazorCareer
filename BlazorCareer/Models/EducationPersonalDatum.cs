using System;
using System.Collections.Generic;

namespace BlazorCareer.Models;

public partial class EducationPersonalDatum
{
    public int EducationPersonal { get; set; }

    public int? EducationId { get; set; }

    public int? PersonalDataId { get; set; }

    public virtual Education? Education { get; set; }

    public virtual PersonalDatum? PersonalData { get; set; }
}
