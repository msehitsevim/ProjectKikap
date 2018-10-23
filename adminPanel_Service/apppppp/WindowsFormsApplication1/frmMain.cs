using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ServiceReference1;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            frmBooks gecis = new frmBooks();
            gecis.ShowDialog();

        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            frmBookAdd gecis = new frmBookAdd();
            gecis.ShowDialog();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            frmCustomers gecis = new frmCustomers();
            gecis.ShowDialog();
        }

        IiService1Client svc = new IiService1Client();

        private void frmMain_Load(object sender, EventArgs e)
        {
            orderList("");
        }

        void orderList(string deGet)
        {
            List<ServiceReference1.Orders> orderList = svc.talepGetir(deGet).ToList();

            var query = orderList.Select(c => new
            {
                c.id,
                c.customerID,
                c.bookID,
                c.orderDetail,
                c.orderCount
                
            }).ToList();

            dgvOrders.DataSource = query;
        }
    }
}
