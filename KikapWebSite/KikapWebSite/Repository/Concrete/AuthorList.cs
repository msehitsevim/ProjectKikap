using KikapWebSite.Models;
using KikapWebSite.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KikapWebSite.Repository.Concrete
{
    public class AuthorList: IAuthorList
    {

        public List<Author> author()
        {

            using (KiKapEntities db = new KiKapEntities())
            {
                return db.Authors.ToList();
            }
        }
    }
}