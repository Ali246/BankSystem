using BankSystem.Data;
using BankSystem.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BankSystem.IService
{
    public interface IContactService
    {
        Task<List<CustomContactModel>> GetContacts();
        Task<List<ContactTypeEnum>> GetContactsEnum();
        Task<bool> AddContact(Contact newContact);
        Task<bool> UpdateContact(Contact updateContact);
        Task<bool> DeleteContact(CustomContactModel deleteContact);
        Contact GetContactById(int Id);
    }
}
