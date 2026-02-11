using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public abstract class TimeAudit : Identity
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}