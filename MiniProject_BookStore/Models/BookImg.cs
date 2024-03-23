using System;
using System.Collections.Generic;

namespace MiniProject_BookStore.Models;

public partial class BookImg
{
    public int BookId { get; set; }

    public byte[]? Img { get; set; }

    public virtual Book Book { get; set; } = null!;
}
