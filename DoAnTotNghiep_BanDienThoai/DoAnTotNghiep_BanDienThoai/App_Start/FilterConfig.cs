using System.Web;
using System.Web.Mvc;

namespace DoAnTotNghiep_BanDienThoai
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
