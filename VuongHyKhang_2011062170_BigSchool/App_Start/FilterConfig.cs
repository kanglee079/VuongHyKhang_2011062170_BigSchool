using System.Web;
using System.Web.Mvc;

namespace VuongHyKhang_2011062170_BigSchool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
