using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentApi.Models;

[Table("Students")]
public class Students
{
    [Key]
    public int Id { get; set; }

    public required string Name { get; set; }

    public required string Surname { get; set; }

    public int Age { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public required string UserName { get; set; }

    public required string Password { get; set; }
}
