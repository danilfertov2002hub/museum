using System;
using System.Collections.Generic;

namespace museum;

public partial class Item
{
    public int IdItem { get; set; }

    public string NameItem { get; set; } = null!;

    public int? MuseumId { get; set; }

    public string Age { get; set; } = null!;

    public DateTime StorageDate { get; set; }

    public virtual ICollection<MovingRecord> MovingRecords { get; } = new List<MovingRecord>();

    public virtual Museum? Museum { get; set; }
}
