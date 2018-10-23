using KikapWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KikapWebSite.Repository.Abstract
{
    public interface ICategoryAbstract
    {
        List<Category> CategoryList();
    }
}