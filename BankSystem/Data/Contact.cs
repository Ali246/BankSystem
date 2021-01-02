using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BankSystem.Data
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ContactName { get; set; }
        [Required]
        public string Mobile { get; set; }
        public int ContactType { get; set; }
        public int BankId { get; set; }
        public int AgencyId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? modifiedDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        //public Bank bank { get; set; }
        //public Agency agency { get; set; }
    }
}
