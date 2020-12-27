using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystem.Data
{
    public class Bank
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string BankName { get; set; }
        [Required]
        public string MainBranch { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? modifiedDate { get; set; }
        public DateTime? DeleteDate { get; set; }


    }
}
