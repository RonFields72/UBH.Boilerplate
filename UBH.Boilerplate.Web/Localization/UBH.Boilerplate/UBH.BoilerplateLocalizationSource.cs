using System.Web;
using Abp.Dependency;
using Abp.Localization.Sources.Xml;

namespace UBH.Boilerplate.Web.Localization.UBH.Boilerplate
{
    public class UBH.BoilerplateLocalizationSource : XmlLocalizationSource
    {
        public UBH.BoilerplateLocalizationSource()
            : base("UBH.Boilerplate", HttpContext.Current.Server.MapPath("/Localization/UBH.Boilerplate"))
        {
        }
    }
}