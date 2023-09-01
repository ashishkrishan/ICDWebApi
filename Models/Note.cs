using System;
using System.Collections.Generic;

namespace ICDWebApi.Models;

public partial class Note
{
    public string IcdVersion { get; set; } = null!;

    public string SurgicalProcCode { get; set; } = null!;

    public string? RecordType { get; set; }

    public string? Notes { get; set; }

    public virtual SurgicalCode SurgicalCode { get; set; } = null!;
}
