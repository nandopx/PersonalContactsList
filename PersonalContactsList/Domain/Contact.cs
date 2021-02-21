using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PersonalContactsList.Domain
{
    [Table("CONTACT")]
    public class Contact
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(11)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(40)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Birthday { get; set; }

        [Required]
        public Address Address { get; set; }

        [Required]
        public virtual Guid AddressId { get; set; }

        public Contact ()
        {

        }

        public Contact ( string name, string phoneNumber, string email, DateTime birthday, Address address)
        {
            Id = Guid.NewGuid();
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Birthday = birthday;
            Address = address;
        }
    }
}
