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
    public partial class frmBookUpdate : Form
    {
        public frmBookUpdate()
        {
            InitializeComponent();
        }

        public int bookID = 0;

        IiService1Client svc = new IiService1Client();

        private void frmBookUpdate_Load(object sender, EventArgs e)
        {

            ServiceReference1.Books book = svc.kitapDetay(bookID);

            txtBookName.Text = book.bookName;
            txtAuthor.Text = book.author;
            txtType.Text = book.type;
            txtEditor.Text = book.editor;
            txtTranslator.Text = book.translator;
            txtPageNumber.Text = book.pageNumbers.ToString();
            txtFormat.Text = book.format_;
            txtPublisher.Text = book.publisher;
            txtPublicationDate.Text = book.publicationDate.ToString();
            txtLangu.Text = book.language;
            txtEdition.Text = book.edition.ToString();
            txtBalance.Text = book.price.ToString();
            txtSize.Text = book.size;
            txtISBN.Text = book.ISBN;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            ServiceReference1.Books book = new ServiceReference1.Books();

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
            book.ID = bookID;

            int mesaj = svc.kitapGuncelle(book);

            if (mesaj == 1)
            {
                MessageBox.Show("Güncelleme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("İşlem Başarısız");
            }

            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ServiceReference1.Books book = svc.kitapDetay(bookID);

            int mesaj = svc.kitapSil(book);

            if (mesaj == 1)
            {
                MessageBox.Show("Silme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("İşlem Başarısız");
            }

            this.Hide();
        }
    }
}
