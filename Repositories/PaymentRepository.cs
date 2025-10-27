using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_Pest_Control.Data;
using UTS_Pest_Control.Models;

namespace UTS_Pest_Control.Repositories
{
    public class PaymentRepository
    {
        private readonly AppDbContext _context;

        public PaymentRepository(AppDbContext context) 
        {
            _context = context;
        }
        public IEnumerable<Payment> GetAll() 
        {
            return _context.Payments.ToList();
        }

        public Payment GetById(int id) 
        {
            return _context.Payments.FirstOrDefault(p => p.PaymentID == id);
        }

        public void Add(Payment payment) 
        {
            _context.Payments.Add(payment);
            _context.SaveChanges();
        }
        public void Update(Payment payment) 
        {
            _context.Payments.Update(payment);
            _context.SaveChanges();
        }

        public void Delete(int id) 
        {
            var payment = _context.Payments.Find(id);
            if (payment != null) 
            {
                _context.Payments.Remove(payment);
                _context.SaveChanges();
            }
        }
    }
}
