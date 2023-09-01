using System;
using System.Collections.Generic;

namespace ICDWebApi.Models;

public partial class Aec
{
    public string IcdVersion { get; set; } = null!;

    public string SurgicalProcCode { get; set; } = null!;

    public string? RecordType { get; set; }

    public int? AutoErrorCd { get; set; }

    public DateTime? AutoErrorEffDt { get; set; }

    public DateTime? AutoErrorEndDt { get; set; }

    public string? StatusInd { get; set; }

    public DateTime? CreateTs { get; set; }

    public int? CreateUserId { get; set; }

    public DateTime? UpdateTs { get; set; }

    public int? UpdateUserId { get; set; }

    public virtual SurgicalCode SurgicalCode { get; set; } = null!;
}
