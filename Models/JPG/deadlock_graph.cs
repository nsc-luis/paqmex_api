using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.JPG;

public partial class deadlock_graph
{
    public int RowNumber { get; set; }

    public int? EventClass { get; set; }

    public long? EventSequence { get; set; }

    public int? IsSystem { get; set; }

    public string? LoginName { get; set; }

    public byte[]? LoginSid { get; set; }

    public int? SPID { get; set; }

    public string? ServerName { get; set; }

    public string? SessionLoginName { get; set; }

    public DateTime? StartTime { get; set; }

    public string? TextData { get; set; }

    public long? TransactionID { get; set; }

    public byte[]? BinaryData { get; set; }
}
