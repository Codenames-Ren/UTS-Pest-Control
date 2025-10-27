using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_Pest_Control.Data;
using UTS_Pest_Control.Models;

namespace UTS_Pest_Control.Repositories
{
    public class PackageRepository
    {
        private readonly AppDbContext _context;

        public PackageRepository(AppDbContext context)
        { 
           _context = context; 
        }

        public IEnumerable<Package> GetAll()
        { 
            return _context.Packages.ToList();
        }

        public Package GetById(int id)
        {
            return _context.Packages.FirstOrDefault(p => p.PackageID == id);
        }

        public void Add(Package package) 
        {
            _context.Packages.Add(package);
            _context.SaveChanges();
        }

        public void Update(Package package) 
        {
            _context.Packages.Update(package);
            _context.SaveChanges();
        }
        public void Delete(int id) 
        {
            var package = _context.Packages.Find(id);
            if (package != null) 
            {
                _context.Packages.Remove(package);
                _context.SaveChanges();
            }
        }
    }
}
