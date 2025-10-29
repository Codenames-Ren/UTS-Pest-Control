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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
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
            dtpServiceDate = new DateTimePicker();
            label5 = new Label();
            dgvPayments = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(39, 23);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "Client";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(39, 65);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Package";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(485, 20);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 2;
            label3.Text = "Payment Method";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(565, 68);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 3;
            label4.Text = "Total";
            // 
            // cmbClient
            // 
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(123, 20);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(265, 28);
            cmbClient.TabIndex = 4;
            // 
            // cmbPackage
            // 
            cmbPackage.FormattingEnabled = true;
            cmbPackage.Location = new Point(123, 60);
            cmbPackage.Name = "cmbPackage";
            cmbPackage.Size = new Size(265, 28);
            cmbPackage.TabIndex = 5;
            cmbPackage.SelectedIndexChanged += cmbPackage_SelectedIndexChanged;
            // 
            // cmbMethod
            // 
            cmbMethod.FormattingEnabled = true;
            cmbMethod.Items.AddRange(new object[] { "Cash", "Transfer Bank", "E-Wallet" });
            cmbMethod.Location = new Point(641, 20);
            cmbMethod.Name = "cmbMethod";
            cmbMethod.Size = new Size(265, 28);
            cmbMethod.TabIndex = 6;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(641, 64);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(265, 27);
            txtTotal.TabIndex = 7;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Goldenrod;
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(810, 175);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 39);
            btnClear.TabIndex = 47;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(680, 175);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 39);
            btnDelete.TabIndex = 46;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(531, 175);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 39);
            btnUpdate.TabIndex = 45;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(385, 175);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 39);
            btnAdd.TabIndex = 44;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtpServiceDate
            // 
            dtpServiceDate.CustomFormat = "\"dd/MM/yyyy HH:mm\"";
            dtpServiceDate.Format = DateTimePickerFormat.Custom;
            dtpServiceDate.Location = new Point(123, 103);
            dtpServiceDate.Name = "dtpServiceDate";
            dtpServiceDate.ShowUpDown = true;
            dtpServiceDate.Size = new Size(265, 27);
            dtpServiceDate.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(44, 103);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 50;
            label5.Text = "Time";
            // 
            // dgvPayments
            // 
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Location = new Point(29, 220);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.RowHeadersWidth = 51;
            dgvPayments.Size = new Size(1055, 380);
            dgvPayments.TabIndex = 48;
            dgvPayments.CellClick += dgvPayments_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(922, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 173);
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1115, 617);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(dtpServiceDate);
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
            Name = "PaymentForm";
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadPackages();
            LoadPayments();

            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;dgvPayments.MultiSelect = false;
        }

        private void LoadClients()
        {
            var clients = _clientService.GetAllClients();
            cmbClient.DataSource = clients;
            cmbClient.DisplayMember = "Name";
            cmbClient.ValueMember = "ClientID"; 
            cmbClient.SelectedIndex = -1;
        }

        private void LoadPackages()
        {
            cmbPackage.SelectedIndexChanged -= cmbPackage_SelectedIndexChanged;

            var packages = _packageService.GetAllPackages();
            cmbPackage.DataSource = packages;
            cmbPackage.DisplayMember = "Name";
            cmbPackage.ValueMember = "PackageID";

            cmbPackage.SelectedIndex = -1;
            txtTotal.Clear();

            cmbPackage.SelectedIndexChanged += cmbPackage_SelectedIndexChanged;
        }

        private void LoadPayments()
        {
            var payments = _paymentService.GetAllPayments();
            dgvPayments.DataSource = payments.Select(p => new
            {
                p.PaymentID,
                ClientName = p.Client?.Name,
                ClientAdress = p.Client?.Address,
                PackageName = p.Package?.Name,
                p.PaymentMethod,
                p.TotalAmount,
                p.PaymentDate,
                p.ServiceDate
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
        private DateTimePicker dtpServiceDate;
        private Label label5;
        private DataGridView dgvPayments;
        private PictureBox pictureBox1;
    }
}