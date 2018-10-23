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
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        IiService1Client svc = new IiService1Client();

        void bookList(string deGet)
        {
            List<ServiceReference1.Books> bookList = svc.kitapGetir(deGet).ToList();

            var query = bookList.Select(c => new
            {
                c.ID,
                c.bookName,
                c.author,
                c.price,
                c.edition,
                c.editor,
                c.language,
            }).ToList();

            dgvBooks.DataSource = query;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBookSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            bookList(txtBookSearch.Text);
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int bookID = Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells[0].Value);

               
                frmBookUpdate frm = new frmBookUpdate();
                frm.bookID = bookID;
                frm.ShowDialog();


                bookList(txtBookSearch.Text);
                
            }
        }
    }
}
