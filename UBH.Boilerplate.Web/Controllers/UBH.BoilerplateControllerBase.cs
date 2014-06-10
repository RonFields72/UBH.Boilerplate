using Abp.Web.Mvc.Controllers;

namespace UBH.Boilerplate.Web.Controllers
{
    public abstract class UBH.BoilerplateControllerBase : AbpController
    {
        protected UBH.BoilerplateControllerBase()
        {
            LocalizationSourceName = "UBH.Boilerplate";
        }
    }
}