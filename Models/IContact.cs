namespace Contacts.Models
{
    public interface IContact
    {
        string Address { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        string PhoneNumber { get; set; }
    }
}