using System.ComponentModel.DataAnnotations;

namespace webapi.Models;

public class Trajectory
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid TaxiId { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public double Latitude { get; set; }

    [Required]
    public double Longitude { get; set; }

    public virtual required Taxi Taxi { get; set; }
}