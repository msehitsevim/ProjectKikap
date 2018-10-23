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
    public partial class frmBookAdd : Form
    {
        public frmBookAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            IiService1Client svc = new IiService1Client();

            ServiceReference1.Books book = new ServiceReference1.Books();


            if (txtBookName.Text != "" && txtType.Text != "" && txtEditor.Text != "" && txtTranslator.Text != "" && txtAuthor.Text != "" && txtPageNumber.Text != "" && txtFormat.Text != "" && txtPublisher.Text != "" && txtPublicationDate.Text != "" && txtLangu.Text != "" && txtEdition.Text != "" && txtBalance.Text != "" && txtSize.Text != "" && txtISBN.Text != "")
            {
                book.bookName = txtBookName.Text;
                book.author = txtAuthor.Text;
                book.type = txtType.Text;
                book.editor = txtEditor.Text;
                book.translator = txtTranslator.Text;
                book.pageNumbers = Convert.ToInt16(txtPageNumber.Text);
                book.format_ = txtFormat.Text;
                book.publisher = txtPublisher.Text;
                book.publicationDate = Convert.ToInt16(txtPublicationDate.Text);
                book.language = txtLangu.Text;
                book.edition = Convert.ToByte(txtEdition.Text);
                book.price = Convert.ToDouble(txtBalance.Text);
                book.size = txtSize.Text;
                book.ISBN = txtISBN.Text;
            }
           
            

            int mesaj = svc.kitapEkle(book);

            if (mesaj == 0)
            {
                MessageBox.Show("Kitap bilgileri ile başka kitap kayıtlı");
            }
            else if (mesaj == -1)
            {
                MessageBox.Show("Bir Hata Oluştu");
            }
            else
            {
                MessageBox.Show("Kitap Ekleme Başarılı");
                this.Hide();
            }
            
        }
        
    }
}
