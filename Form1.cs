using UTS_Pest_Control.Data;
using UTS_Pest_Control.Forms;
using UTS_Pest_Control.Repositories;
using UTS_Pest_Control.Services;

namespace UTS_Pest_Control
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _context;
        private readonly ClientRepository _clientRepository;
        private readonly PackageRepository _packageRepository;
        private readonly PaymentRepository _paymentRepository;
        private readonly ClientService _clientService;
        private readonly PackageService _packageService;
        private readonly PaymentService _paymentService;

        private Panel panelContainer;
        public Form1()
        {
            InitializeComponent();

            //Initialize DbContext & Repository
            _context = new AppDbContext();
            _clientRepository = new ClientRepository(_context);
            _packageRepository = new PackageRepository(_context);
            _paymentRepository = new PaymentRepository(_context);

            //Initialize Service
            _clientService = new ClientService(_clientRepository);
            _packageService = new PackageService(_packageRepository);
            _paymentService = new PaymentService(_paymentRepository, _clientRepository, _packageRepository);

            InitializePanelContainer();
        }

        private void InitializePanelContainer()
        {
            panelContainer = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                Visible = false
            };

            this.Controls.Add(panelContainer);
            panelContainer.BringToFront();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new ClientForm(_clientService));
        }
        private void packageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new PackageForm(_packageService));
        }
        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new PaymentForm(_paymentService, _clientService, _packageService));
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Yakin ingin keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "UTS Pest Control Management System";
        }

        private void OpenForm(Form form)
        {
            panelContainer.Visible = true;
            panelContainer.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(form);
            form.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = false;
        }
    }
}
