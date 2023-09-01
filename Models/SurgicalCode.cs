using System;
using System.Collections.Generic;

namespace ICDWebApi.Models;

public partial class SurgicalCode
{
    public string IcdVersion { get; set; } = null!;

    public string SurgicalProcCode { get; set; } = null!;

    public string? RecordType { get; set; }

    public string? SurgName { get; set; }

    public string? SurgLaymanDesc { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Sex { get; set; }

    public string? AhsfInd { get; set; }

    public string? SecondOpinionInd { get; set; }

    public string? CosmeticSurgInd { get; set; }

    public string? SurgeryInd { get; set; }

    public int? MinAge { get; set; }

    public string? MinAgeInd { get; set; }

    public int? MaxAge { get; set; }

    public string? MaxAgeInd { get; set; }

    public string? StatusInd { get; set; }

    public DateTime? CreateTs { get; set; }

    public int? CreateUserId { get; set; }

    public DateTime? UpdateTs { get; set; }

    public int? UpdateUserId { get; set; }
}
