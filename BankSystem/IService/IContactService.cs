using BankSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BankSystem.IService
{
    public interface IContactService
    {
        Task<List<Contact>> GetContacts();
        Task<bool> AddContact(Contact newContact);
        Task<bool> UpdateContact(Contact updateContact);
        Task<bool> DeleteContact(Contact deleteContact);
        Contact GetContactById(int Id);
    }
}
