namespace UTS_Pest_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clientForm = new Forms.ClientForm();
            clientForm.Show();
        }
        private void packageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var packageForm = new Forms.PackageForm();
            packageForm.Show();
        }
        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var paymentForm = new Forms.PaymentForm();
            paymentForm.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
