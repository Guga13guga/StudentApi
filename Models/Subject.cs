using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentApi.Models;

[Table("Subjects")]
public class Subject
{
    [Key]
    public int Id { get; set; }

    public required string Name { get; set; }

    public string? Description { get; set; }

    public DateTime StartDate { get; set; } = DateTime.Now;

    public DateTime EndDate { get; set; } = DateTime.Now.AddDays(100);
}
