using System;
using BankSystem.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankSystem.CustomModel
{
    public class CustomContactModel
    {
       
        public int Id { get; set; }
      
        public string ContactName { get; set; }
        public string Mobile { get; set; }
        public int ContactType { get; set; }
        public string ContactTypeName { get; set; }
        public int BankId { get; set; }
        public string BankName { get; set; }
        public int AgencyId { get; set; }
        public string AgencyName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? modifiedDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        //public Bank bank { get; set; }
        //public Agency agency { get; set; }
    }
}
