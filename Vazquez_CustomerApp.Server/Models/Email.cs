namespace Vazquez_CustomerApp.Server.Models
{
    public class Email
    {
        public int EmailID { get; set; }

        public int CustomerID { get; set; }

        public string EmailAddress { get; set; }

        public bool IsCurrent { get; set; }
    }
}
