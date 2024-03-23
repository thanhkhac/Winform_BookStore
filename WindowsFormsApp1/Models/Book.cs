using System;
using System.Collections.Generic;

namespace MiniProject_BookStore.Models;

public partial class Book
{
    public int Id { get; set; }

    public string? BarCode { get; set; }

    public string Name { get; set; } = null!;

    public int? BookTypeId { get; set; }

    public string? Author { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public bool? IsActive { get; set; }

    public virtual BookImg? BookImg { get; set; }

    public virtual BookType? BookType { get; set; }

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();
}
