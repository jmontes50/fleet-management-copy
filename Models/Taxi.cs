using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using webapi.Models;

public class Taxi
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(12)]
    public required string Plate { get; set; }
    [JsonIgnore]
    public virtual ICollection<Trajectory>? Trajectories { get; set; }
}