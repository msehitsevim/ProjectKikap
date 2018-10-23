using KikapWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KikapWebSite.Repository.Abstract
{
    public interface IAuthorList
    {
        List<Author> author();
    }
}