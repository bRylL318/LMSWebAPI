using System;
using System.Collections.Generic;

namespace LMSWebAPI.Models;

public partial class TblcourseDetail
{
    public int Id { get; set; }

    public string? CourseNo { get; set; }

    public string? CourseCode { get; set; }

    public string? ChapterTitle { get; set; }

    public string? Categoryid { get; set; }

    public string? ChapterDescription { get; set; }

    public string? ChapterImageUrl { get; set; }

    public int? Cpublish { get; set; }

    public int? Caccess { get; set; }

    public int? Tid { get; set; }
}
