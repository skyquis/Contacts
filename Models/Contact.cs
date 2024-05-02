using System.ComponentModel.DataAnnotations;

namespace Contacts.Models
{
    public class Contact : IContact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
