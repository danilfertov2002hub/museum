using System;
using System.Collections.Generic;

namespace museum;

public partial class Museum
{
    public int IdMuseum { get; set; }

    public string NameMuseum { get; set; } = null!;

    public string City { get; set; } = null!;

    public virtual ICollection<Item> Items { get; } = new List<Item>();

    public virtual ICollection<MovingRecord> MovingRecordEndmuseums { get; } = new List<MovingRecord>();

    public virtual ICollection<MovingRecord> MovingRecordStartmuseums { get; } = new List<MovingRecord>();
}
