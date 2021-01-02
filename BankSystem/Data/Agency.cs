using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BankSystem.Data
{
    public class Agency
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string AgencyName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? modifiedDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
