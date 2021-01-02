using BankSystem.Data;
using BankSystem.IService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace BankSystem.Service
{
    public class AgencyService : IAgencyService
    {
        private readonly ApplicationDbContext _db;
        public AgencyService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Agency>> GetAgencies()
        {
            return await _db.agency.Where(x => x.IsDeleted == false).ToListAsync();
        }
        public async Task<bool> AddAgency(Agency newAgency)
        {
            newAgency.IsDeleted = false;
            newAgency.CreateDate = DateTime.Now;
            await _db.agency.AddAsync(newAgency);
            _db.SaveChanges();
            return true;
        }
        public async Task<bool> UpdateAgency(Agency updateAgency)
        {
            updateAgency.modifiedDate = DateTime.Now;
            _db.agency.Update(updateAgency);
            await _db.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteAgency(Agency deleteAgency)
        {
            _db.agency.Update(deleteAgency);
            await _db.SaveChangesAsync();
            return true;
        }
        public Agency GetAgencyById(int Id)
        {
            return _db.agency.Find(Id); ;
        }
    }
}
