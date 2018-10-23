using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KikapWebSite.Models;

namespace KikapWebSite.Repository.Abstract
{
    public interface IProductAbstract
    {
        Book GetLastProduct();
        List<Book> Product();
    }

}