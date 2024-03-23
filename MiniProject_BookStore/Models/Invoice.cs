using System;
using System.Collections.Generic;

namespace MiniProject_BookStore.Models;

public partial class Invoice
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerPhone { get; set; }

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();
}
