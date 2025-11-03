using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentApi.Models;

[Table("Teachers")]
public class Teacher
{
    [Key]
    public int Id { get; set; }

    public required string Name { get; set; }

    public required string Surname { get; set; }

    public decimal Wage { get; set; }

    [EmailAddress]
    public string? Email { get; set; }
}
