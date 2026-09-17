using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StoreManagementSystem
{
    /* الواجهة الرابعة: عملية بيع جديدة
       Controls المطلوبة على الفورم:
       - comboBox : cboProduct
       - label    : lblPrice, lblStock, lblTotal
       - textBox  : txtQty
       - button   : btnSave, btnClose */
    public partial class FormSales : Form
    {
        decimal currentPrice = 0;
        int currentStock = 0;
        string currentUser = "";

        public FormSales()
        {
            InitializeComponent();
        }

        public FormSales(string user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void FormSales_Load(object sender, EventArgs e)
        {
            loadProductsCombo();
        }

        // تحميل المنتجات داخل ComboBox من قاعدة البيانات
        void loadProductsCombo()
        {
            DbConn db = new DbConn();
            db.disconnect();
            string SQL = "select ProductID, ProductName from Products";
            SqlCommand cmd = new SqlCommand(SQL, db.connect());
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            db.conn.Close();

            cboProduct.DataSource = dt;
            cboProduct.DisplayMember = "ProductName";
            cboProduct.ValueMember = "ProductID";
        }

        // عند اختيار منتج نجلب سعره والكمية المتوفرة منه بالمخزون
        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProduct.SelectedValue == null) return;

            DbConn db = new DbConn();
            db.disconnect();
            string SQL = "select Price, Quantity from Products where ProductID=" + cboProduct.SelectedValue;
            SqlCommand cmd = new SqlCommand(SQL, db.connect());
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                currentPrice = Convert.ToDecimal(dr["Price"]);
                currentStock = Convert.ToInt32(dr["Quantity"]);
                lblPrice.Text = currentPrice.ToString();
                lblStock.Text = currentStock.ToString();
            }
            db.conn.Close();
        }

        // حساب الإجمالي تلقائيا أثناء كتابة الكمية
        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            int qty;
            if (int.TryParse(txtQty.Text, out qty))
                lblTotal.Text = (qty * currentPrice).ToString();
            else
                lblTotal.Text = "0";
        }

        // حفظ عملية البيع + تحديث المخزون
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int qty = Convert.ToInt32(txtQty.Text);
                if (qty <= 0 || qty > currentStock)
                {
                    MessageBox.Show("Quantity not available in stock");
                    return;
                }

                // 1) تسجيل عملية البيع في جدول Sales
                DbConn db = new DbConn();
                db.disconnect();
                string SQL = "insert into Sales (ProductID, Quantity, Total, UserName) " +
                             "values (@pid,@qty,@total,@user)";
                SqlCommand cmd = new SqlCommand(SQL, db.connect());
                cmd.Parameters.AddWithValue("@pid", cboProduct.SelectedValue);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@total", qty * currentPrice);
                cmd.Parameters.AddWithValue("@user", string.IsNullOrEmpty(currentUser) ? Environment.UserName : currentUser);
                cmd.ExecuteNonQuery();
                db.conn.Close();

                // 2) تحديث كمية المخزون في جدول Products
                DbConn db2 = new DbConn();
                db2.disconnect();
                string SQL2 = "update Products set Quantity = Quantity - @qty where ProductID=@pid";
                SqlCommand cmd2 = new SqlCommand(SQL2, db2.connect());
                cmd2.Parameters.AddWithValue("@qty", qty);
                cmd2.Parameters.AddWithValue("@pid", cboProduct.SelectedValue);
                cmd2.ExecuteNonQuery();
                db2.conn.Close();

                MessageBox.Show("Sale Saved Successfully");
                loadProductsCombo();
                txtQty.Text = "";
                lblTotal.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
