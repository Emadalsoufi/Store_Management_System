using System;
using System.Windows.Forms;

namespace StoreManagementSystem
{
    /* الواجهة الثانية: القائمة الرئيسية (Dashboard)
       Controls المطلوبة على الفورم:
       - label  : lblWelcome
       - button : btnProducts (Text >>> Products)
       - button : btnSales    (Text >>> New Sale)
       - button : btnReports  (Text >>> Reports)
       - button : btnLogout   (Text >>> Logout) */
    public partial class FormMain : Form
    {
        string userType;
        string userName;
        string loginName;

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(string type, string name, string login)
        {
            InitializeComponent();
            userType = type;
            userName = name;
            loginName = login;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + userName + "  (" + userType + ")";

            if (userType != "Admin")
                btnReports.Enabled = false;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            FormProducts fp = new FormProducts();
            fp.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            FormSales fs = new FormSales(loginName);
            fs.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            FormReports fr = new FormReports();
            fr.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
