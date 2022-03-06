using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{

    public class User
    {
        [Required] public string Subject { get; set; }
        [Required] public string Message { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Email { get; set; }
    }

}