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
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        IiService1Client svc = new IiService1Client();

        int CustomerID = 0;

        void customerList(string deGet)
        {
            List<ServiceReference1.Customers> custList = svc.musteriGetir(deGet).ToList();

            var query = custList.Select(c => new
            {
                c.id,
                c.name,
                c.sirname,
               
            }).ToList();

            dgvMusteriler.DataSource = query;
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            customerList("");
        }

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                CustomerID = Convert.ToInt32(dgvMusteriler.Rows[e.RowIndex].Cells[0].Value);
                gboxMusteriDetay.Visible = true;

                ServiceReference1.Customers cust = svc.musteriDetay(CustomerID);
                txtAddress.Text = cust.address;
                txtEmail.Text = cust.mail;
                txtPhone.Text = cust.phone;
                txtTcNo.Text = cust.tcNo;
            }
        }
    }
}
