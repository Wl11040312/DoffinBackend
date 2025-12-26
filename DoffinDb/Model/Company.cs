using System;
using System.Collections.Generic;

namespace DoffinDb.Model;

public partial class Company
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ICollection<AppUser> AppUser { get; set; } = new List<AppUser>();
}
