using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StoreManagementSystem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DbConn db = new DbConn();
                db.disconnect();

                string SQL = "select * from Users where Username='" + txtUsername.Text +
                             "' and Password='" + txtPassword.Text + "'";

                SqlCommand cmd = new SqlCommand(SQL, db.connect());
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string userType = dr["UserType"].ToString();
                    string fullName = dr["FullName"].ToString();
                    string userName = dr["Username"].ToString();
                    dr.Close();
                    db.conn.Close();

                    MessageBox.Show("Welcome " + fullName);

                    FormMain fm = new FormMain(userType, fullName, userName);
                    this.Hide();
                    fm.ShowDialog();
                    this.Close();
                }
                else
                {
                    dr.Close();
                    db.conn.Close();
                    MessageBox.Show("Username or Password is incorrect");
                    txtPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
