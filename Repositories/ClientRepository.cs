using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_Pest_Control.Data;
using UTS_Pest_Control.Models;

namespace UTS_Pest_Control.Repositories
{
    public class ClientRepository
    {
        private readonly AppDbContext _context;

        public ClientRepository(AppDbContext context) 
        {
            _context = context;
        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients.ToList();
        }
        public Client GetById(int id)
        {
            return _context.Clients.FirstOrDefault(c => c.ClientID == id);
        }

        public void Add(Client client) 
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public void Update(Client client)
        {
            var existingClient = _context.Clients.Find(client.ClientID);
            if (existingClient != null)
            {
                existingClient.Name = client.Name;
                existingClient.Address = client.Address;
                existingClient.Phone = client.Phone;
                existingClient.Email = client.Email;

                _context.SaveChanges();
            }
        }


        public void Delete(int id) 
        {
            var client = _context.Clients.Find(id);
            if (client != null)
            { 
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }
        }
    }
}
