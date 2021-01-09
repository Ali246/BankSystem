using BankSystem.Data;
using BankSystem.CustomModel;
using BankSystem.IService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace BankSystem.Service
{
    public class ContactService : IContactService
    {
        private readonly ApplicationDbContext _db;
        public ContactService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<List<CustomContactModel>> GetContacts()
        {     
            List<CustomContactModel> Result = new List<CustomContactModel>();
            Result =  await (from contact in _db.contact.Where(x => x.IsDeleted == false)
                             join ContactType in _db.ContactTypeEnum on contact.ContactType equals ContactType.Value
                             select new CustomContactModel
                             {
                                 Id = contact.Id,
                                 ContactName = contact.ContactName,
                                 ContactType = contact.ContactType,
                                 BankId = contact.BankId,
                                 AgencyId = contact.AgencyId,
                                 Mobile = contact.Mobile,
                                 CreateDate = contact.CreateDate,
                                 DeleteDate = contact.DeleteDate,
                                 IsDeleted = contact.IsDeleted,
                                 modifiedDate = contact.modifiedDate,
                                 AgencyName = contact.AgencyId != 0 ? _db.agency.Where(a => a.Id == contact.AgencyId).FirstOrDefault().AgencyName : "",
                                 BankName = contact.BankId != 0 ? _db.bank.Where(a => a.Id == contact.BankId).FirstOrDefault().BankName : "",
                                 ContactTypeName = ContactType.Name
                             }).ToListAsync();

            return  Result;
        }
        public async Task<List<ContactTypeEnum>> GetContactsEnum() 
        {

            return await _db.ContactTypeEnum.Select(x => x).ToListAsync();
        }
        public async Task<bool> AddContact(Contact newContact)
        {
            if (newContact.ContactType == 2) // 2 is contact type for bank representive
            {
                newContact.AgencyId = 0;
            }
            else if (newContact.ContactType == 3) //3 is contact type for agency representive
            {
                newContact.BankId = 0;
            }
            else //1 is contact type for Client
            {
                newContact.AgencyId = 0;
                newContact.BankId = 0;
            }
            newContact.IsDeleted = false;
            newContact.CreateDate = DateTime.Now;
           await _db.contact.Add(newContact).ReloadAsync();
            _db.SaveChanges();
            return true;
        }
        public async Task<bool> UpdateContact(Contact updateContact)
        {

            if (updateContact.ContactType == 2) // 2 is contact type for bank representive
            {
                updateContact.AgencyId = 0;
            }
            else if (updateContact.ContactType == 3) //3 is contact type for agency representive
            {
                updateContact.BankId = 0;
            }
            else //1 is contact type for Client
            { 
                updateContact.AgencyId = 0;
                updateContact.BankId = 0;
            }
            updateContact.modifiedDate = DateTime.Now;
             _db.contact.Update(updateContact);

            await _db.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteContact(CustomContactModel deleteContact)
        {
            Contact contact = _db.contact.Where(x => x.Id == deleteContact.Id).FirstOrDefault();
            contact.DeleteDate = deleteContact.DeleteDate;
            contact.IsDeleted = deleteContact.IsDeleted;
            _db.contact.Update(contact);
            await _db.SaveChangesAsync();
            return true;
        }
        public Contact GetContactById(int Id)
        {
            return _db.contact.Find(Id); ;
        }
    }
}
