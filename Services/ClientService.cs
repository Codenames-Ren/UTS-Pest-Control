using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_Pest_Control.Models;
using UTS_Pest_Control.Repositories;

namespace UTS_Pest_Control.Services
{
    public class ClientService
    {
        private readonly ClientRepository _clientRepository;

        public ClientService(ClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public IEnumerable<Client> GetAllClients()
        {
            return _clientRepository.GetAll();
        }
        public Client GetClientById(int id) 
        {
            return _clientRepository.GetById(id);
        }
        public void AddClient(Client client) 
        {
            //Validasi Input
            client.Name = client.Name?.Trim();
            client.Address = client.Address?.Trim();
            client.Phone = client.Phone?.Trim();

            if (string.IsNullOrWhiteSpace(client.Name)) throw new System.Exception("Nama Client tidak boleh kosong!");
            if (string.IsNullOrWhiteSpace(client.Address)) throw new System.Exception("Alamat tidak boleh kosong!");
            if (string.IsNullOrWhiteSpace(client.Phone)) throw new System.Exception("Nomor telepon tidak boleh kosong!");
            _clientRepository.Add(client);
        }

        public void UpdateClient(Client client) 
        {
            client.Name = client.Name?.Trim();
            client.Address = client.Address?.Trim();
            client.Phone = client.Phone?.Trim();
            
            if (string.IsNullOrWhiteSpace(client.Name)) throw new System.Exception("Nama Client tidak boleh kosong!");
            if (string.IsNullOrWhiteSpace(client.Address)) throw new System.Exception("Alamat tidak boleh kosong!");
            if (string.IsNullOrWhiteSpace(client.Phone)) throw new System.Exception("Nomor telepon tidak boleh kosong!");
            _clientRepository.Update(client);
        }

        public void DeleteClient(int id) 
        {
            _clientRepository.Delete(id);
        }
    }
}
