using System.ComponentModel.DataAnnotations.Schema;

namespace Users.Model
{
    public class User
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public string? LastName { get; set; }
        public required string Email { get; set; }

        [ForeignKey("AddressId")]
        public virtual Address? Address { get; set; }
    }
}
