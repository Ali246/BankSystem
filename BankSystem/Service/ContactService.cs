using BankSystem.Data;
using BankSystem.IService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankSystem.Service
{
    public class ContactService : IContactService
    {
        private readonly ApplicationDbContext _db;
        public ContactService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Contact>> GetContacts()
        {
            return await _db.contact.Where(x => x.IsDeleted == false).ToListAsync();
        }
        public async Task<bool> AddContact(Contact newContact)
        {
            newContact.IsDeleted = false;
            newContact.CreateDate = DateTime.Now;
            await _db.contact.AddAsync(newContact);
            _db.SaveChanges();
            return true;
        }
        public async Task<bool> UpdateContact(Contact updateContact)
        {
            updateContact.modifiedDate = DateTime.Now;
            _db.contact.Update(updateContact);
            await _db.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteContact(Contact deleteContact)
        {
            _db.contact.Update(deleteContact);
            await _db.SaveChangesAsync();
            return true;
        }
        public Contact GetContactById(int Id)
        {
            return _db.contact.Find(Id); ;
        }
    }
}
