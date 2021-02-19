using PersonalContactsList.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalContactsList.Domain
{
    [Table("ADDRESS")]
    public class Address
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string LineAddress { get; set; }

        [Required]
        [MaxLength(5)]
        public string Number { get; set; }

        [MaxLength(20)]
        public string Complement { get; set; }

        [Required]
        [MaxLength(40)]
        public string District { get; set; }

        [Required]
        [MaxLength(40)]
        public string Cyty { get; set; }

        [Required]
        [MaxLength(2)]
        public Province Province { get; set; }

        [Required]
        [MaxLength(8)]
        public string PostalCode { get; set; }

        [Required]
        [MaxLength(9)]
        public AddressType AddressType { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }

        public Address ( Guid id, string lineAddress, string number, string complement, 
            string district, string cyty, Province province, string postalCode, 
            AddressType addressType )
        {
            Id = Guid.NewGuid();
            LineAddress = lineAddress;
            Number = number;
            Complement = complement;
            District = district;
            Cyty = cyty;
            Province = province;
            PostalCode = postalCode;
            AddressType = addressType;
        }
    }
}
