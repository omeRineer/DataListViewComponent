using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVCUI.ViewComponents
{
    public class DataListViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(IEnumerable dataList)
        {
            return View(dataList);
        }
    }
}
