namespace UTS_Pest_Control.Forms
{
    partial class ClientForm
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
            dgvClients = new DataGridView();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtClientEmail = new TextBox();
            txtClientPhone = new TextBox();
            txtClientAddress = new TextBox();
            txtClientName = new TextBox();
            txtClientID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // dgvClients
            // 
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(34, 190);
            dgvClients.Margin = new Padding(3, 2, 3, 2);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 51;
            dgvClients.Size = new Size(807, 285);
            dgvClients.TabIndex = 29;
            dgvClients.CellContentClick += dgvClients_CellContentClick;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(431, 144);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 29);
            btnClear.TabIndex = 28;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(318, 144);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 29);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(187, 144);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 29);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(60, 144);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 29);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtClientEmail
            // 
            txtClientEmail.Location = new Point(563, 16);
            txtClientEmail.Margin = new Padding(3, 2, 3, 2);
            txtClientEmail.Name = "txtClientEmail";
            txtClientEmail.Size = new Size(228, 23);
            txtClientEmail.TabIndex = 24;
            // 
            // txtClientPhone
            // 
            txtClientPhone.Location = new Point(86, 88);
            txtClientPhone.Margin = new Padding(3, 2, 3, 2);
            txtClientPhone.Name = "txtClientPhone";
            txtClientPhone.Size = new Size(232, 23);
            txtClientPhone.TabIndex = 23;
            // 
            // txtClientAddress
            // 
            txtClientAddress.Location = new Point(563, 52);
            txtClientAddress.Margin = new Padding(3, 2, 3, 2);
            txtClientAddress.Multiline = true;
            txtClientAddress.Name = "txtClientAddress";
            txtClientAddress.Size = new Size(228, 84);
            txtClientAddress.TabIndex = 22;
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(89, 51);
            txtClientName.Margin = new Padding(3, 2, 3, 2);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(228, 23);
            txtClientName.TabIndex = 21;
            // 
            // txtClientID
            // 
            txtClientID.Location = new Point(89, 11);
            txtClientID.Margin = new Padding(3, 2, 3, 2);
            txtClientID.Name = "txtClientID";
            txtClientID.ReadOnly = true;
            txtClientID.Size = new Size(228, 23);
            txtClientID.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(498, 16);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 19;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 88);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 18;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 52);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 17;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 51);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 16;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 14);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 15;
            label1.Text = "Client ID";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 496);
            Controls.Add(dgvClients);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtClientEmail);
            Controls.Add(txtClientPhone);
            Controls.Add(txtClientAddress);
            Controls.Add(txtClientName);
            Controls.Add(txtClientID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClientForm";
            Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClients;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtClientEmail;
        private TextBox txtClientPhone;
        private TextBox txtClientAddress;
        private TextBox txtClientName;
        private TextBox txtClientID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}