using System.ComponentModel.DataAnnotations;

namespace MVC5Course.Models
{
    public interface IClientBatchUpdate
    {
        int ClientId { get; set; }
        [Required]
        string FirstName { get; set; }
        [Required]
        string LastName { get; set; }
        [Required]
        string MiddleName { get; set; }
    }
}