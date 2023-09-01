using System;
using System.Collections.Generic;

namespace ICDWebApi.Models;

public partial class Spc
{
    public string IcdVersion { get; set; } = null!;

    public string SurgicalProcCode { get; set; } = null!;

    public string? RecordType { get; set; }

    public int? SpcCd { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? SpcInclExcl { get; set; }

    public string? StatusInd { get; set; }

    public DateTime? CreateTs { get; set; }

    public int? CreateUserId { get; set; }

    public DateTime? UpdateTs { get; set; }

    public int? UpdateUserId { get; set; }

    public virtual SurgicalCode SurgicalCode { get; set; } = null!;
}
