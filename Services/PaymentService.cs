using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_Pest_Control.Models;
using UTS_Pest_Control.Repositories;

namespace UTS_Pest_Control.Services
{
    public class PaymentService
    {
        private readonly PaymentRepository _paymentRepository;
        private readonly ClientRepository _clientRepository;
        private readonly PackageRepository _packageRepository;

        public PaymentService(
            PaymentRepository paymentRepository, ClientRepository clientRepository, PackageRepository packageRepository)
        {
            _paymentRepository = paymentRepository;
            _clientRepository = clientRepository;
            _packageRepository = packageRepository;
        }
        public IEnumerable<Payment> GetAllPayments() 
        {
            return _paymentRepository.GetAll();
        }
        public Payment GetPaymentById(int id) 
        {
            return _paymentRepository.GetById(id);
        }
        public void AddPayment(Payment payment) 
        {
            payment.PaymentMethod = payment.PaymentMethod?.Trim();

            var client = _clientRepository.GetById(payment.ClientID);
            var package = _packageRepository.GetById(payment.PackageID);

            if (client == null) throw new System.Exception("Client tidak ditemukan!");
            if (package == null) throw new System.Exception("Paket tidak ditemukan!");
            if (string.IsNullOrWhiteSpace(payment.PaymentMethod)) throw new System.Exception("Metode Pembayaran tidak boleh kosong!");

            payment.TotalAmount = package.Price;
            _paymentRepository.Add(payment);
        }
        public void UpdatePayment(Payment payment)
        {
            payment.PaymentMethod = payment.PaymentMethod?.Trim();
            if (string.IsNullOrWhiteSpace(payment.PaymentMethod)) throw new System.Exception("Metode pembayaran tidak boleh kosong!");

            _paymentRepository.Update(payment);
        }
        public void DeletePayment(int id) 
        {
            _paymentRepository.Delete(id);
        }
    }
}
