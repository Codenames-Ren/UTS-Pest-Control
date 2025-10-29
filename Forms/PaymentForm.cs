using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTS_Pest_Control.Models;
using UTS_Pest_Control.Services;

namespace UTS_Pest_Control.Forms
{
    public partial class PaymentForm : Form
    {
        private readonly PaymentService _paymentService;
        private readonly ClientService _clientService;
        private readonly PackageService _packageService;
        public PaymentForm(PaymentService paymentService, ClientService clientService, PackageService packageService)
        {
            InitializeComponent();
            _paymentService = paymentService;
            _clientService = clientService;
            _packageService = packageService;

            LoadClients();
            LoadPayments();
            LoadPackages();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbClient.SelectedIndex == -1 || cmbPackage.SelectedIndex == -1 || cmbMethod.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtTotal.Text.Trim()))
            {
                MessageBox.Show("Semua field harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtTotal.Text.Trim(), out decimal total))
            {
                MessageBox.Show("Total harus berupa angka!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var payment = new Payment
            {
                ClientID = (int)cmbClient.SelectedValue,
                PackageID = (int)cmbPackage.SelectedValue,
                PaymentMethod = cmbMethod.SelectedItem.ToString(),
                TotalAmount = total,
                PaymentDate = DateTime.UtcNow,
                ServiceDate = DateTime.SpecifyKind(dtpServiceDate.Value, DateTimeKind.Utc),
                PaymentStatus = "Paid"
            };

            try
            {
                _paymentService.AddPayment(payment);
                MessageBox.Show("Pembayaran berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPayments();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih transaksi yang ingin diupdate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedId = (int)dgvPayments.SelectedRows[0].Cells["PaymentID"].Value;

            if (!decimal.TryParse(txtTotal.Text.Trim(), out decimal total))
            {
                MessageBox.Show("Total harus berupa angka!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var payment = new Payment
            {
                PaymentID = selectedId,
                ClientID = (int)cmbClient.SelectedValue,
                PackageID = (int)cmbPackage.SelectedValue,
                PaymentMethod = cmbMethod.SelectedItem.ToString(),
                TotalAmount = total,
                PaymentDate = DateTime.Now.ToUniversalTime(),
                ServiceDate = DateTime.SpecifyKind(dtpServiceDate.Value, DateTimeKind.Utc),
                PaymentStatus = "Paid"
            };

            try
            {
                _paymentService.UpdatePayment(payment);
                MessageBox.Show("Transaksi berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPayments();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih transaksi yang ingin dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedId = (int)dgvPayments.SelectedRows[0].Cells["PaymentID"].Value;
            var confirm = MessageBox.Show("Yakin ingin menghapus transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _paymentService.DeletePayment(selectedId);
                    MessageBox.Show("Transaksi berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPayments();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void cmbPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPackage.SelectedValue == null || cmbPackage.SelectedValue is not int)
                return;

            int selectedPackageId = (int)cmbPackage.SelectedValue;
            var package = _packageService.GetPackageById(selectedPackageId);

            if (package != null)
            {
                txtTotal.Text = package.Price.ToString("N0"); // otomatis isi harga paket
            }
        }

        private void dgvPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPayments.Rows[e.RowIndex];
                cmbClient.Text = row.Cells["ClientName"].Value?.ToString();
                cmbPackage.Text = row.Cells["PackageName"].Value?.ToString();
                cmbMethod.Text = row.Cells["PaymentMethod"].Value?.ToString();
                txtTotal.Text = row.Cells["TotalAmount"].Value?.ToString();
            }
        }
    }
}
