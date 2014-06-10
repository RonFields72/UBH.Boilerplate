using Abp.Web.Mvc.Views;

namespace UBH.Boilerplate.Web.Views
{
    public abstract class UBH.BoilerplateWebViewPageBase : UBH.BoilerplateWebViewPageBase<dynamic>
    {

    }

    public abstract class UBH.BoilerplateWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected UBH.BoilerplateWebViewPageBase()
        {
            LocalizationSourceName = "UBH.Boilerplate";
        }
    }
}