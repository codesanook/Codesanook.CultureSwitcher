using System.Web.Mvc;
using Orchard.Localization.Providers;

namespace Codesanook.CultureSwitcher.Controllers {
    public class CultureSwitcherController : Controller
    {
        private readonly ICultureStorageProvider cultureStorageProvider;
        public CultureSwitcherController(ICultureStorageProvider cultureStorageProvider) {
            this.cultureStorageProvider = cultureStorageProvider;
        }

        public ActionResult SetCulture(string culture)
        {
            cultureStorageProvider.SetCulture(culture);
            // Simplify redirect to home, this can be improve by passing return URL parameter  
            return Redirect("/");
        }
    }
}