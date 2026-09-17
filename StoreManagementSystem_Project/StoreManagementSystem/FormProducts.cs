using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StoreManagementSystem
{
    /* الواجهة الثالثة: إدارة المنتجات (CRUD + Search)
       Controls المطلوبة على الفورم:
       - textBox  : txtId, txtName, txtPrice, txtQty, txtSearch
       - comboBox : cboCategory
       - button   : btnAdd, btnUpdate, btnDelete, btnClose
       - dataGridView : dataProducts */
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            loadCategories();
            loadProducts();
        }

        // تحميل الأصناف داخل ComboBox من قاعدة البيانات (نفس فكرة Example 7)
        void loadCategories()
        {
            DbConn db = new DbConn();
            db.disconnect();
            string SQL = "select CategoryName from Categories";
            SqlCommand cmd = new SqlCommand(SQL, db.connect());
            SqlDataReader dr = cmd.ExecuteReader();

            cboCategory.Items.Clear();
            while (dr.Read())
            {
                cboCategory.Items.Add(dr["CategoryName"].ToString());
            }
            db.conn.Close();
        }

        // عرض كل المنتجات داخل DataGridView (نفس فكرة View Data from SqlServer)
        void loadProducts()
        {
            DbConn db = new DbConn();
            db.disconnect();
            string SQL = "select p.ProductID, p.ProductName, c.CategoryName, p.Price, p.Quantity " +
                         "from Products p inner join Categories c on p.CategoryID = c.CategoryID";
            SqlCommand cmd = new SqlCommand(SQL, db.connect());
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dataProducts.DataSource = dt;
            db.conn.Close();
        }

        int getCategoryId(string categoryName)
        {
            DbConn db = new DbConn();
            db.disconnect();
            string SQL = "select CategoryID from Categories where CategoryName='" + categoryName + "'";
            SqlCommand cmd = new SqlCommand(SQL, db.connect());
            object id = cmd.ExecuteScalar();
            db.conn.Close();
            return Convert.ToInt32(id);
        }

        // Create : إضافة منتج جديد
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || cboCategory.Text == "" || txtPrice.Text == "" || txtQty.Text == "")
                {
                    MessageBox.Show("Please fill all product fields");
                    return;
                }

                DbConn db = new DbConn();
                db.disconnect();
                string SQL = "insert into Products (ProductName, CategoryID, Price, Quantity) " +
                             "values (@name,@cat,@price,@qty)";
                SqlCommand cmd = new SqlCommand(SQL, db.connect());
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@cat", getCategoryId(cboCategory.Text));
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@qty", txtQty.Text);
                cmd.ExecuteNonQuery();
                db.conn.Close();

                MessageBox.Show("Product Added");
                clearFields();
                loadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Update : تعديل بيانات منتج
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DbConn db = new DbConn();
                db.disconnect();
                string SQL = "update Products set ProductName=@name, CategoryID=@cat, " +
                             "Price=@price, Quantity=@qty where ProductID=@id";
                SqlCommand cmd = new SqlCommand(SQL, db.connect());
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@cat", getCategoryId(cboCategory.Text));
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@qty", txtQty.Text);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.ExecuteNonQuery();
                db.conn.Close();

                MessageBox.Show("Product Updated");
                clearFields();
                loadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Delete : حذف منتج
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please select a product from the table first");
                return;
            }

            DialogResult d = MessageBox.Show("Do you want to delete this product?", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (d == DialogResult.Yes)
            {
                DbConn db = new DbConn();
                db.disconnect();
                string SQL = "delete from Products where ProductID=" + txtId.Text;
                SqlCommand cmd = new SqlCommand(SQL, db.connect());
                cmd.ExecuteNonQuery();
                db.conn.Close();

                MessageBox.Show("Product Deleted");
                clearFields();
                loadProducts();
            }
        }

        // Read/Search : بحث باسم المنتج أثناء الكتابة
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbConn db = new DbConn();
            db.disconnect();
            string SQL = "select p.ProductID, p.ProductName, c.CategoryName, p.Price, p.Quantity " +
                         "from Products p inner join Categories c on p.CategoryID = c.CategoryID " +
                         "where p.ProductName like '%" + txtSearch.Text + "%'";
            SqlCommand cmd = new SqlCommand(SQL, db.connect());
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dataProducts.DataSource = dt;
            db.conn.Close();
        }

        // عند الضغط على صف بالجدول تنتقل بياناته إلى الحقول لتعديله أو حذفه
        private void dataProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataProducts.CurrentRow != null)
            {
                txtId.Text = dataProducts.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dataProducts.CurrentRow.Cells[1].Value.ToString();
                cboCategory.Text = dataProducts.CurrentRow.Cells[2].Value.ToString();
                txtPrice.Text = dataProducts.CurrentRow.Cells[3].Value.ToString();
                txtQty.Text = dataProducts.CurrentRow.Cells[4].Value.ToString();
            }
        }

        void clearFields()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            cboCategory.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
