using System;
using System.Collections.Generic;

namespace LMSWebAPI.Models;

public partial class TblUser
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Ename { get; set; }

    public string? EStatus { get; set; }

    public int? AccountType { get; set; }

    public int? EInactive { get; set; }

    public int? A { get; set; }

    public int? B { get; set; }
}
