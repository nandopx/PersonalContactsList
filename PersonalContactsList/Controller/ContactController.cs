using PersonalContactsList.Data;
using PersonalContactsList.Domain;
using PersonalContactsList.Domain.Enums;
using System;

namespace PersonalContactsList.Controller
{
    public class ContactController
    {
        public void NewContact (string name, string phoneNumber, string email, 
            string birthday, string lineAddres, string number, string complement, 
            string district, string city, string province, string postalCode, string addresdType)
        {
            var EProvince = Enum.Parse<Province>( province );
            var EAddressType = Enum.Parse<AddressType>( addresdType );

            var address = new Address( lineAddres, number, complement, district, city, EProvince,
                postalCode, EAddressType );

            DateTime _birthday = DateTime.Parse( birthday ).Date;

            var contact = new Contact( name, phoneNumber, email, _birthday, address );

            using (var db = new ContactsContext())
            {
                db.Adresses.Add(address);
                db.Contacts.Add(contact);
                db.SaveChanges();
            }
        }
    }
}
