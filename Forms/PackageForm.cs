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
    public partial class PackageForm : Form
    {
        private readonly PackageService packageService;
        public PackageForm(PackageService packageService)
        {
            InitializeComponent();
            _packageService = packageService;
        }

        private void PackageForm_Load(object sender, EventArgs e)
        {
            LoadPackages();
            dgvPackages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPackages.MultiSelect = false;
        }

        private void LoadPackages()
        {
            dgvPackages.DataSource = _packageService.GetAllPackages()
                .Select(p => new
                {
                    p.PackageID,
                    p.Name,
                    p.Description,
                    p.Price
                }).ToList();
        }

        private void ClearInputs()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string desc = txtDescription.Text.Trim();
            string price = txtPrice.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(desc) || string.IsNullOrWhiteSpace(price))
            {
                MessageBox.Show("Semua field harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Harga harus berupa angka!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var package = new Package
            {
                PackageName = name,
                Description = desc,
                Price = price
            };

            _packageService.AddPackage(package);
            MessageBox.Show("Paket berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadPackages();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPackages.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih paket yang ingin diupdate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedld = (int)dgvPackages.SelectedRows[0].Cells["PackageID"].Value;

            string name = txtName.Text.Trim();
            string desc = txtDescription.Text.Trim();
            string price = txtPrice.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(desc) || string.IsNullOrWhiteSpace(priceText))
            {
                MessageBox.Show("Semua field harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(price, out decimal price))
            {
                MessageBox.Show("Harga harus berupa angka!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var package = new Package
            {
                PackageID = selectedld,
                PackageName = name,
                Description = desc,
                Price = price
            };

            _packageService.UpdatePackage(package);
            MessageBox.Show("Paket berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadPackages();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPackages.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih paket yang ingin dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedld = (int)dgvPackages.SelectedRows[0].Cells["PackageID"].Value;

            var confirm = MessageBox.Show("Yakin ingin menghapus paket ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _packageService.DeletePackage(selectedld);
                MessageBox.Show("Paket berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPackages();
                ClearInputs();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void dgvPackages_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex >= 0) 
            { 
                var row = dgvPackages.Rows[e.RowIndex];
                txtName.Text = row.Cells["PackageName"].Value?.ToString();
                txtDescription.Text = row.Cells["Description"].Value?.ToString();
                txtPrice.Text = row.Cells["price"].Value?.ToString();
            }
        }
    }
}
