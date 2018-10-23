using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService1.Model;


namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "iService1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select iService1.svc or iService1.svc.cs at the Solution Explorer and start debugging.
    public class iService1 : IiService1
    {
        public Books kitapDetay(int ID)
        {
            KiKapEntities db = new KiKapEntities();

            Books book = db.Books.FirstOrDefault(c => c.ID == ID);

            return book;
        }

        public int kitapEkle(Books book)
        {
            KiKapEntities db = new KiKapEntities();

            List<Books> kitapVarMi = db.Books.Where(c => c.bookName.Contains(book.bookName) && c.author.Contains(book.author)).ToList();

            if (kitapVarMi.Count > 0)
            {
                return 0;
            }

            try
            {
                db.Books.Add(book);
                db.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public List<Books> kitapGetir(string deGet)
        {
            KiKapEntities db = new KiKapEntities();

            List<Books> bookList = db.Books.Where(c => c.bookName.Contains(deGet) || c.author.Contains(deGet)).ToList();

            return bookList;
        }

        public int kitapGuncelle(Books book)
        {
            KiKapEntities db = new KiKapEntities();

            Books yeni = db.Books.FirstOrDefault(c => c.ID == book.ID);

            yeni.bookName = book.bookName;
            yeni.author = book.author;
            yeni.type = book.type;
            yeni.editor = book.editor;
            yeni.translator = book.translator;
            yeni.pageNumbers = book.pageNumbers;
            yeni.format_ = book.format_;
            yeni.publisher = book.publisher;
            yeni.publicationDate = book.publicationDate;
            yeni.language = book.language;
            yeni.edition = book.edition;
            yeni.price = book.price;
            yeni.size = book.size;
            yeni.ISBN = book.ISBN;
            

            try
            {
                db.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int kitapSil(Books book)
        {
            KiKapEntities db = new KiKapEntities();
            try
            {
                List<Books> bookList = db.Books.Where(c => c.ID == book.ID).ToList();

                foreach (var item in bookList)
                {
                    db.Books.Remove(item);
                    db.SaveChanges();
                }


                return 1;
            }
            catch (Exception)
            {
                return -1;
            }

        }

        public Customers musteriDetay(int id)
        {
            KiKapEntities db = new KiKapEntities();

            Customers cust = db.Customers.FirstOrDefault(c => c.id == id);

            return cust;
        }

        public List<Customers> musteriGetir(string deGet)
        {
            KiKapEntities db = new KiKapEntities();

            List<Customers> customerList = db.Customers.Where(c => c.name.Contains(deGet) || c.sirname.Contains(deGet)).ToList();

            return customerList;
        }

        public List<Orders> talepGetir(string deGet)
        {
            KiKapEntities db = new KiKapEntities();

            List<Orders> orderList = db.Orders.Where(c => c.orderDetail.Contains(deGet)).ToList();

            return orderList;
        }
    }
}
