using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class EFEntertainerRepository : IEntertainerRepository
    {
        private EntAgencyDBContext _context { get; set; }

        public EFEntertainerRepository(EntAgencyDBContext temp)
        {
            _context = temp;
        }

        public IQueryable<Entertainer> Entertainers => _context.Entertainers;

        public void AddEntertainer(Entertainer ENT)
        {
            _context.Entertainers.Add(ENT);
        }

        public void DeleteEntertainer(Entertainer ENT)
        {
            _context.Remove(ENT);
        }

        public void EditEntertainer(Entertainer ENT)
        {
            _context.Update(ENT);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
