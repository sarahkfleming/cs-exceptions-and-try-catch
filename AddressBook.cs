using System.Collections.Generic;

namespace AnAddressBook
{
    public class AddressBook
    {

        public Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();

        public void AddContact(Contact person)
        {
            addressBook.Add(person.Email, person);
        }

        public Contact GetByEmail(string email)
        {
                if (addressBook.ContainsKey(email))
                {
                    return addressBook[email];
                }
                else
                {
                    return null;
                }
        }
    }
}