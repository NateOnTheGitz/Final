using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public interface IEntertainerRepository
    {
        IQueryable<Entertainer> Entertainers { get; }

        void AddEntertainer(Entertainer ENT);
        void DeleteEntertainer(Entertainer ENT);
        void EditEntertainer(Entertainer ENT);
        void Save();
    }
}
