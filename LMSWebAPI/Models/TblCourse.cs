using System;
using System.Collections.Generic;

namespace LMSWebAPI.Models;

public partial class TblCourse
{
    public int Id { get; set; }

    public string? CourseNo { get; set; }

    public DateTime? CourseDate { get; set; }

    public string? CourseName { get; set; }

    public string? CourseDescription { get; set; }

    public string? CourseImageUrl { get; set; }

    public string? Sdate { get; set; }

    public string? Suser { get; set; }

    public string? Edate { get; set; }

    public string? Euser { get; set; }

    public int? CourseStatus { get; set; }
}
