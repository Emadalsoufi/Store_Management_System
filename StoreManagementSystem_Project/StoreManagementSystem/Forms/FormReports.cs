using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StoreManagementSystem
{
    /* الواجهة الخامسة: التقارير (Reports)
       Controls المطلوبة على الفورم:
       - button       : btnSalesReport (Text >>> Sales Report)
       - button       : btnLowStock    (Text >>> Low Stock Report)
       - label        : lblTotalSales
       - dataGridView : dataReport
       - button       : btnClose */
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
        }

        // تقرير كل عمليات البيع (join بين Sales و Products)
        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            DbConn db = new DbConn();
            db.disconnect();
            string SQL = "select s.SaleID, p.ProductName, s.Quantity, s.Total, s.SaleDate, s.UserName " +
                         "from Sales s inner join Products p on s.ProductID = p.ProductID " +
                         "order by s.SaleDate desc";
            SqlCommand cmd = new SqlCommand(SQL, db.connect());
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dataReport.DataSource = dt;
            db.conn.Close();

            calcTotal();
        }

        // تقرير المنتجات التي أوشك مخزونها على النفاذ ( أقل من 10 قطع )
        private void btnLowStock_Click(object sender, EventArgs e)
        {
            DbConn db = new DbConn();
            db.disconnect();
            string SQL = "select ProductName, Quantity from Products where Quantity < 10";
            SqlCommand cmd = new SqlCommand(SQL, db.connect());
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dataReport.DataSource = dt;
            db.conn.Close();

            lblTotalSales.Text = "";
        }

        // حساب إجمالي المبيعات باستخدام ExecuteScalar
        void calcTotal()
        {
            DbConn db = new DbConn();
            db.disconnect();
            string SQL = "select sum(Total) from Sales";
            SqlCommand cmd = new SqlCommand(SQL, db.connect());
            object result = cmd.ExecuteScalar();
            db.conn.Close();

            lblTotalSales.Text = "Total Sales : " + (result == DBNull.Value ? "0" : result.ToString());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
