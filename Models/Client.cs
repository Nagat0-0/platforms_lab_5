using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace lab_5.Models;

public partial class Client
{
    public int Id { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string PassportNumber { get; set; } = null!;

    public string? Address { get; set; }

    public string? Phone { get; set; }
}
