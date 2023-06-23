using System;
using System.Collections.Generic;

namespace BlazorCareer.Models;

public partial class PersonalDatum
{
    public int PersonalDataId { get; set; }

    public string? Position { get; set; }

    public string? Prefix { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? NickName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public int? Age { get; set; }

    public double? Height { get; set; }

    public double? Weight { get; set; }

    public string? IdCardNumber { get; set; }

    public string? ContactNumber { get; set; }

    public string? Email { get; set; }

    public string? AddressPresent { get; set; }

    public string? StreetPresent { get; set; }

    public string? SubDistrictPresent { get; set; }

    public string? DistrictPresent { get; set; }

    public string? ProvincePresent { get; set; }

    public string? AddressRegistration { get; set; }

    public string? StreetRegistration { get; set; }

    public string? SubDistrictRegistration { get; set; }

    public string? DistrictRegistration { get; set; }

    public string? ProvinceRegistration { get; set; }

    public string? MaritalStatus { get; set; }

    public int? NumberOfChildren { get; set; }

    public string? MilitaryStatus { get; set; }

    public string? EmergencyContact { get; set; }

    public string? Relationship { get; set; }

    public string? ContractNumber { get; set; }

    public int? EducationId { get; set; }

    public int? WorkingExperienceId { get; set; }

    public int? SpecialAbilityId { get; set; }

    public virtual ICollection<EducationPersonalDatum> EducationPersonalData { get; set; } = new List<EducationPersonalDatum>();
}
