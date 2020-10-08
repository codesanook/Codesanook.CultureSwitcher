using System.Globalization;
using System.Linq;
using Codesanook.CultureSwitcher.Models;
using Orchard;
using Orchard.ContentManagement.Drivers;
using Orchard.Localization.Services;
using Orchard.Utility.Extensions;

namespace Codesanook.CultureSwitcher.Drivers {
    public class CultureSwitcherPartDriver : ContentPartDriver<CultureSwitcherPart> {
        private readonly ICultureManager cultureManager;
        private readonly IWorkContextAccessor workContextAccessor;

        public CultureSwitcherPartDriver(
            ICultureManager cultureManager,
            IWorkContextAccessor workContextAccessor

        ) {
            this.cultureManager = cultureManager;
            this.workContextAccessor = workContextAccessor;
        }

        protected override DriverResult Display(CultureSwitcherPart part, string displayType, dynamic shapeHelper) {

            var cultures = cultureManager.ListCultures().Select(c => new CultureInfo(c));
            part.CurrentCulture = workContextAccessor.GetContext().CurrentCulture;
            part.SupportedCultures = cultureManager.ListCultures().ToArray();

            return ContentShape(
                "Parts_CultureSwitcher",
                () => shapeHelper.Parts_CultureSwitcher(
                    CurrentCulture: part.CurrentCulture,
                    SupportedCultures: part.SupportedCultures
                )
            );
        }
    }
}