using System.ComponentModel.DataAnnotations;

namespace UserManager.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
    }
}
