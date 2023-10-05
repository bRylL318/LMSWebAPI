using System;
using System.Collections.Generic;

namespace LMSWebAPI.Models;

public partial class TblcourseCategory
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? CategoryName { get; set; }

    public string? Sdate { get; set; }

    public string? Suser { get; set; }

    public string? Edate { get; set; }

    public string? Euser { get; set; }

    public string? Status { get; set; }
}
