using System;
using System.Collections.Generic;

namespace PmqLesson10.Models;

public partial class PmqMember
{
    public long MemberId { get; set; }

    public string? PmqUserName { get; set; }

    public string? PmqPassword { get; set; }

    public string? PmqFullName { get; set; }

    public string? PmqEmail { get; set; }

    public string? PmqPhone { get; set; }

    public bool? PmqStatus { get; set; }
}
