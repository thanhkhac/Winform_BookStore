using System;
using System.Collections.Generic;

namespace MiniProject_BookStore.Models;

public partial class Account
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool? IsActive { get; set; }

    public bool? IsAdmin { get; set; }
}
