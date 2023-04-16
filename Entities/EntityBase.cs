using System;
using System.ComponentModel.DataAnnotations;

namespace InterView.Domain.Entities;

public abstract class EntityBase
{
    protected EntityBase() => DateAdded = DateTime.UtcNow;

    [DataType(DataType.DateTime)]
    public DateTime DateAdded { get; set; }
}