using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace lab_5.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Cost { get; set; }

    public decimal DailyRentalPrice { get; set; }
}
