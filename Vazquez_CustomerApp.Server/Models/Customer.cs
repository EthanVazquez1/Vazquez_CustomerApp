using System.ComponentModel.DataAnnotations;

namespace Vazquez_CustomerApp.Server.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        
        [Required]
        public DateTime Birthdate { get; set; }
        
        public ICollection<Phone> PhoneNumbers { get; set; }

        public ICollection<Email> Emails { get; set; }

        public ICollection<CustomerAddress> Address { get; set; }
    }
}
