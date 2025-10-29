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
    public partial class ClientForm : Form
    {
        private readonly ClientService _clientService;
        public ClientForm(ClientService clientservice)
        {
            InitializeComponent();
            _clientService = clientservice;

            LoadClients();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            LoadClients();
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.MultiSelect = false;
        }

        private void LoadClients()
        {
            dgvClients.DataSource = _clientService.GetAllClients().Select(c => new
            {
                c.ClientID,
                c.Name,
                c.Address,
                c.Phone,
                c.Email,
            }).ToList();
        }

        private void ClearInputs()
        {
            txtClientName.Text = "";
            txtClientAddress.Text = "";
            txtClientPhone.Text = "";
            txtClientEmail.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtClientName.Text.Trim();
            string address = txtClientAddress.Text.Trim();
            string phone = txtClientPhone.Text.Trim();
            string email = txtClientEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Semua field harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi format email dengan regex(Regular Expression)
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Format email tidak valid!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi nomor telepon
            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Nomor telepon hanya boleh berisi angka!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (phone.Length < 10)
            {
                MessageBox.Show("Nomor telepon terlalu pendek!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cegah duplikasi email
            var existingClient = _clientService.GetAllClients()
                .FirstOrDefault(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

            if (existingClient != null)
            {
                MessageBox.Show("Client dengan email ini sudah terdaftar!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var client = new Client
            {
                Name = name,
                Address = address,
                Phone = phone,
                Email = email
            };

            _clientService.AddClient(client);
            MessageBox.Show("Client berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadClients();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih client yang ingin diupdate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedId = (int)dgvClients.SelectedRows[0].Cells["ClientId"].Value;

            string name = txtClientName.Text.Trim();
            string address = txtClientAddress.Text.Trim();
            string phone = txtClientPhone.Text.Trim();
            string email = txtClientEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Semua field harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Format email tidak valid!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Nomor telepon hanya boleh berisi angka!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (phone.Length < 10)
            {
                MessageBox.Show("Nomor telepon terlalu pendek!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existingClient = _clientService.GetAllClients()
                .FirstOrDefault(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && c.ClientID != selectedId);

            if (existingClient != null)
            {
                MessageBox.Show("Email ini sudah digunakan oleh client lain!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var client = new Client
            {
                ClientID = selectedId,
                Name = name,
                Address = address,
                Phone = phone,
                Email = email,
            };

            _clientService.UpdateClient(client);
            MessageBox.Show("Client berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadClients();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih client yang ingin dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedId = (int)dgvClients.SelectedRows[0].Cells["ClientId"].Value;

            var confirm = MessageBox.Show("Yakin ingin menghapus client ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _clientService.DeleteClient(selectedId);
                MessageBox.Show("Client berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadClients();
                ClearInputs();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvClients.Rows[e.RowIndex];
                txtClientName.Text = row.Cells["Name"].Value?.ToString();
                txtClientAddress.Text = row.Cells["Address"].Value?.ToString();
                txtClientPhone.Text = row.Cells["Phone"].Value?.ToString();
                txtClientEmail.Text = row.Cells["Email"].Value?.ToString();
            }
        }
    }

}
