using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace api.Models
{
    public class Client
    {
        public Client() { }

        public Client(string id, string firstName, string lastName, string email, string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        [Key]
        [Required]
        public string Id { get; set; }

        [Required(ErrorMessage ="First Name is required.")]
        [StringLength(50,MinimumLength =6)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "last Name is required.")]
        [StringLength(50,MinimumLength =6)]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Email is required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage ="Phone Number is required.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}

