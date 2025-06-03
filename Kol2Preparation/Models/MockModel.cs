using System.ComponentModel.DataAnnotations;

namespace Kol2Preparation.Models;

public class MockModel
{
    [Key]
    public int Id { get; set; }
    [MaxLength(100)]
    public required string FirstName { get; set; }
    [MaxLength(100)]
    public required string LastName { get; set; }
    [EmailAddress]
    public required string Email { get; set; }
    
    // in case 1 to many connection
    // public virtual ICollection<Prescription> Prescriptions { get; set; }
    
    //in case FK
    // public virtual OtherModel Model { get; set; }

}