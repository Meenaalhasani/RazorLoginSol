﻿using System;
using System.Collections.Generic;

namespace RazorLogin.Models;

public partial class Event
{
    public int EventId { get; set; }

    public string? EventName { get; set; }

    public TimeOnly EventStartTime { get; set; }

    public TimeOnly EventEndTime { get; set; }

    public int EventEmployeeRepId { get; set; }

    public virtual Employee EventEmployeeRep { get; set; } = null!;
}
