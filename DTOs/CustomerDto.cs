using System;

namespace FluentValidationApp.Web.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Email { get; set; }
        public int Yas { get; set; }
        public string Information { get; set; }
        public string CreditCardNumber { get; set; }
        public DateTime CreditCardValidDate { get; set; }
    }
}