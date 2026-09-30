using System;
using System.Collections.Generic;

namespace PmqLesson12.Models;

public partial class Product
{
    public string PmqId { get; set; } = null!;

    public string PmqName { get; set; } = null!;

    public decimal PmqPrice { get; set; }

    public decimal? PmqSalePrice { get; set; }

    public string PmqStatus { get; set; } = null!;

    public DateTime PmqCreateDate { get; set; }

    public string? PmqImages { get; set; }

    public string? PmqCategoryId { get; set; }

    public string? PmqDescription { get; set; }
}
