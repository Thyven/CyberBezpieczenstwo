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

        public int userID;
        public string userName;
        public bool isAdmin = false;

        public void Refresh()
        {
            labelUsername.Text = userName;

            if (isAdmin)
            {
                labeAdmin.Visible = true;
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Validator valdiator = new Validator(this);
            valdiator.Show();
            this.Enabled = false;

          //  data.LoadJson("data.json");
          //  data.DebugData();

        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword valdiator = new ChangePassword(this);
            valdiator.Show();
            this.Enabled = false;

        }
    }
}