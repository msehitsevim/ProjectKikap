using KikapWebSite.Models;
using KikapWebSite.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KikapWebSite.Repository.Concrete
{
    public class CategoryConcrete : ICategoryAbstract
    {
        public List<Category> CategoryList()
        {
            using (KiKapEntities db = new KiKapEntities())
            {
                return db.Categories.ToList();
            }
        }
    }
}