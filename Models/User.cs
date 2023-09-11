#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FormSubmission.Models;

public class User
{
    [Required]
    [MinLength(3)]
    public string FirstName { get; set; }
    
    [Required]
    [MinLength(3)]
    public string LastName { get; set; }
    
    [Required]
    [Range(18, 110)]
    public int Age { get; set; }
    
    [DataType(DataType.EmailAddress)]
    [Required]
    public string Email { get; set; }
   
   
    [Required]
    [MinLength(6)]
    public string Password { get; set; }
}