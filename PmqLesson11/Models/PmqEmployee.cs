using System;
using System.Collections.Generic;

namespace PmqLesson11.Models;

public partial class PmqEmployee
{
    public long Id { get; set; }

    public string PmqName { get; set; } = null!;

    public string? PmqGender { get; set; }

    public DateOnly? PmqBirthDay { get; set; }

    public string? PmqEmail { get; set; }

    public string? PmqPhone { get; set; }

    public bool PmqActive { get; set; }
}
