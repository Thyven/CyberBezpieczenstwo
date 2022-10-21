using CyberBezpieczenstwo.Data;
using CyberBezpieczenstwo.PopUpForms;

namespace CyberBezpieczenstwo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        DataHandler data = new DataHandler();

        public string userName;

        public void Refresh()
        {
            labelUsername.Text = userName;
        }













        private void Form1_Load(object sender, EventArgs e)
        {
            Validator valdiator = new Validator(this);
            valdiator.Show();
            this.Enabled = false;

        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword valdiator = new ChangePassword(this);
            valdiator.Show();
            this.Enabled = false;

        }
    }
}