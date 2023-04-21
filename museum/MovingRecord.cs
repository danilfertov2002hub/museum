using System;
using System.Collections.Generic;

namespace museum;

public partial class MovingRecord
{
    public int IdRecord { get; set; }

    public int StartmuseumId { get; set; }

    public int EndmuseumId { get; set; }

    public int ItemId { get; set; }

    public virtual Museum Endmuseum { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;

    public virtual Museum Startmuseum { get; set; } = null!;
}
