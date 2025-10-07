using System;
using System.Collections.Generic;

namespace PAQMEX_API.Models.JPG;

public partial class deadlock
{
    public int RowNumber { get; set; }

    public int? EventClass { get; set; }

    public string? ApplicationName { get; set; }

    public long? BigintData1 { get; set; }

    public byte[]? BinaryData { get; set; }

    public int? ClientProcessID { get; set; }

    public int? DatabaseID { get; set; }

    public string? DatabaseName { get; set; }

    public long? Duration { get; set; }

    public DateTime? EndTime { get; set; }

    public long? EventSequence { get; set; }

    public int? GroupID { get; set; }

    public string? HostName { get; set; }

    public int? IntegerData { get; set; }

    public int? IntegerData2 { get; set; }

    public int? IsSystem { get; set; }

    public string? LoginName { get; set; }

    public byte[]? LoginSid { get; set; }

    public int? Mode { get; set; }

    public string? NTDomainName { get; set; }

    public string? NTUserName { get; set; }

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
