using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankSystem.Data
{
    public class BankAccount
    {
        [Key]
        public int Id { get; set; }
        public int BankId { get; set; }
        [Required]
        public string AccountNumber { get; set; }
        [Required]
        public string Currency { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? modifiedDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public ICollection<Bank> bank { get; set; }
    }
}
