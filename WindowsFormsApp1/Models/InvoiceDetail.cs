using System;
using System.Collections.Generic;

namespace MiniProject_BookStore.Models;

public partial class InvoiceDetail
{
    public int Id { get; set; }

    public int BookId { get; set; }

    public int? Quantity { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Invoice IdNavigation { get; set; } = null!;
}
