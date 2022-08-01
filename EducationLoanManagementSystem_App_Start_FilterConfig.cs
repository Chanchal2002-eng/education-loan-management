using EducationLoanManagementSystem.Controllers;
using System.Web;
using System.Web.Mvc;

namespace EducationLoanManagementSystem
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomExceptionFilter());
        }
    }
}
