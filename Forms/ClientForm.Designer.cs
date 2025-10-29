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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvClients
            // 
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(25, 253);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 51;
            dgvClients.Size = new Size(936, 380);
            dgvClients.TabIndex = 29;
            dgvClients.CellClick += dgvClients_CellClick;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Goldenrod;
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(582, 192);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 39);
            btnClear.TabIndex = 28;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(452, 192);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 39);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(303, 192);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 39);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(158, 192);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 39);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtClientEmail
            // 
            txtClientEmail.Location = new Point(701, 21);
            txtClientEmail.Name = "txtClientEmail";
            txtClientEmail.Size = new Size(260, 27);
            txtClientEmail.TabIndex = 24;
            // 
            // txtClientPhone
            // 
            txtClientPhone.Location = new Point(99, 70);
            txtClientPhone.Name = "txtClientPhone";
            txtClientPhone.Size = new Size(265, 27);
            txtClientPhone.TabIndex = 23;
            // 
            // txtClientAddress
            // 
            txtClientAddress.Location = new Point(701, 69);
            txtClientAddress.Multiline = true;
            txtClientAddress.Name = "txtClientAddress";
            txtClientAddress.Size = new Size(260, 111);
            txtClientAddress.TabIndex = 22;
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(99, 21);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(265, 27);
            txtClientName.TabIndex = 21;
            // 
            // txtClientID
            // 
            txtClientID.Location = new Point(701, 204);
            txtClientID.Name = "txtClientID";
            txtClientID.ReadOnly = true;
            txtClientID.Size = new Size(260, 27);
            txtClientID.TabIndex = 20;
            txtClientID.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(627, 21);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 19;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(25, 70);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 18;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(623, 69);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 17;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(25, 21);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 16;
            label2.Text = "Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 144);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1000, 661);
            Controls.Add(pictureBox1);
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
            Name = "ClientForm";
            Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}