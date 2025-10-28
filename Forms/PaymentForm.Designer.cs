
using System.IO.Packaging;
using UTS_Pest_Control.Models;

namespace UTS_Pest_Control.Forms
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbClient = new ComboBox();
            cmbPackage = new ComboBox();
            cmbMethod = new ComboBox();
            txtTotal = new TextBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvPayments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 17);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Client";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 66);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Package";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(424, 15);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 2;
            label3.Text = "Payment Method";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 68);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Total";
            // 
            // cmbClient
            // 
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(108, 15);
            cmbClient.Margin = new Padding(3, 2, 3, 2);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(232, 23);
            cmbClient.TabIndex = 4;
            // 
            // cmbPackage
            // 
            cmbPackage.FormattingEnabled = true;
            cmbPackage.Location = new Point(108, 62);
            cmbPackage.Margin = new Padding(3, 2, 3, 2);
            cmbPackage.Name = "cmbPackage";
            cmbPackage.Size = new Size(232, 23);
            cmbPackage.TabIndex = 5;
            // 
            // cmbMethod
            // 
            cmbMethod.FormattingEnabled = true;
            cmbMethod.Items.AddRange(new object[] { "Cash", "Transfer Bank", "E-Wallet" });
            cmbMethod.Location = new Point(561, 15);
            cmbMethod.Margin = new Padding(3, 2, 3, 2);
            cmbMethod.Name = "cmbMethod";
            cmbMethod.Size = new Size(232, 23);
            cmbMethod.TabIndex = 6;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(561, 65);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(232, 23);
            txtTotal.TabIndex = 7;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(511, 118);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 29);
            btnClear.TabIndex = 47;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(397, 118);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 29);
            btnDelete.TabIndex = 46;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(267, 118);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 29);
            btnUpdate.TabIndex = 45;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(139, 118);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 29);
            btnAdd.TabIndex = 44;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvPayments
            // 
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Location = new Point(31, 165);
            dgvPayments.Margin = new Padding(3, 2, 3, 2);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.RowHeadersWidth = 51;
            dgvPayments.Size = new Size(807, 285);
            dgvPayments.TabIndex = 48;
            dgvPayments.CellContentClick += dgvPayments_CellContentClick;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 463);
            Controls.Add(dgvPayments);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtTotal);
            Controls.Add(cmbMethod);
            Controls.Add(cmbPackage);
            Controls.Add(cmbClient);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PaymentForm";
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadPackagdes();
            LoadPayments();

            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;dgvPayments.MultiSelect = false;
        }

        private void LoadClients()
        {
            var clients = _packageService.GetAllPackages().ToList();
            cmbPackage.DataSource = Package;
            cmbPackage.DisplayMember = "Package Name";
            cmbPackage.ValueMember = "Package ID";
        }

        private void LoadPayments()
        {
            dgvPayments.DataSource = _packageService.GetAllPayments()
                .Select(p => new
                {
                    p.PaymentID,
                    ClientName = p.Client?.Name,
                    PackageName = p.Package?.PackageName,
                    p.PaymentMethod,
                    p.TotalAmaount,
                    p,
                    PaymentDate
                }).ToList();
        }

        private void ClearInputs()
        {
            cmbClient.SelectedIndex = -1;
            cmbPackage.SelectedIndex = -1;
            cmbMethod.SelectedIndex = -1;
            txtTotal.Text = "";
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbClient;
        private ComboBox cmbPackage;
        private ComboBox cmbMethod;
        private TextBox txtTotal;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvPayments;
    }
}