using KikapWebSite.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KikapWebSite.Models;

namespace KikapWebSite.Repository.Concrete
{
    public class ProductConcrete : IProductAbstract
    {
        public Book GetLastProduct()
        {
            using (KiKapEntities db = new Models.KiKapEntities())
            {
                return db.Books.OrderByDescending(p => p.ID).FirstOrDefault();
            }
        }

       

        public List<Book> Product()
        {


            using (KiKapEntities db = new KiKapEntities())
            {
                return db.Books.ToList();
            }
        }

    }
}