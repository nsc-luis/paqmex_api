using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.JPG;

public partial class deadlock_chain
{
    public int RowNumber { get; set; }

    public int? EventClass { get; set; }

    public long? BigintData1 { get; set; }

    public byte[]? BinaryData { get; set; }

    public int? DatabaseID { get; set; }

    public string? DatabaseName { get; set; }

    public long? EventSequence { get; set; }

    public int? EventSubClass { get; set; }

    public int? IntegerData { get; set; }

    public int? IntegerData2 { get; set; }

    public int? IsSystem { get; set; }

    public byte[]? LoginSid { get; set; }

    public int? Mode { get; set; }

    public int? ObjectID { get; set; }

    public long? ObjectID2 { get; set; }

    public int? OwnerID { get; set; }

    public int? RequestID { get; set; }

    public int? SPID { get; set; }

    public string? ServerName { get; set; }

    public string? SessionLoginName { get; set; }

    public DateTime? StartTime { get; set; }

    public string? TextData { get; set; }

    public long? TransactionID { get; set; }

    public int? Type { get; set; }
}
