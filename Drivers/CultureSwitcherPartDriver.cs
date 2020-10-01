using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Codesanook.CultureSwitcher.Models;
using Orchard.ContentManagement.Drivers;

namespace Codesanook.CultureSwitcher.Drivers {
    public class CultureSwitcherPartDriver : ContentPartDriver<CultureSwitcherPart> {

        protected override DriverResult Display(CultureSwitcherPart part, string displayType, dynamic shapeHelper) {
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