using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.Models
{
    public class Client
    {
        [Key, Column(Order = 1)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public int PhoneNumber { get; set; }
        public int FaxNumber { get; set; }
        public int CreditLimit { get; set; }
        public Role Role { get; set; }

    }
}
