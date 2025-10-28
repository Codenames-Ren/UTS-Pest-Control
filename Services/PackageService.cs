using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_Pest_Control.Models;
using UTS_Pest_Control.Repositories;

namespace UTS_Pest_Control.Services
{
    public class PackageService
    {
        private readonly PackageRepository _packageRepository;
        
        public PackageService(PackageRepository packageRepository) 
        {
            _packageRepository = packageRepository;
        }
        public IEnumerable<Package> GetAllPackages() 
        {
            return _packageRepository.GetAll();
        }
        public Package GetPackageById(int id) 
        {
            return _packageRepository.GetById(id);
        }
        public void AddPackage(Package package) 
        {
            package.Name = package.Name?.Trim();
            package.Description = package.Description?.Trim();

            if (string.IsNullOrWhiteSpace(package.Name)) throw new System.Exception("Nama paket tidak boleh kosong!");
            if (string.IsNullOrWhiteSpace(package.Description)) throw new System.Exception("Deskripsi paket tidak boleh kosong!");
            if (package.Price <= 0) throw new System.Exception("Harga paket harus lebih dari 0!");
            _packageRepository.Add(package);
        }

        public void UpdatePackage(Package package) 
        {
            package.Name = package.Name?.Trim();
            package.Description = package.Description?.Trim();

            if (string.IsNullOrWhiteSpace(package.Name)) throw new System.Exception("Nama paket tidak boleh kosong!");
            if (string.IsNullOrWhiteSpace(package.Description)) throw new System.Exception("Deskripsi paket tidak boleh kosong!");
            if (package.Price <= 0) throw new System.Exception("Harga paket harus lebih dari 0!");
            _packageRepository.Update(package);
        }
        public void DeletePackage(int id) 
        {
            _packageRepository.Delete(id);
        }
    }
}
