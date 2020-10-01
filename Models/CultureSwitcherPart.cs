using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement;

namespace Codesanook.CultureSwitcher.Models {
    public class CultureSwitcherPart : ContentPart {

        public string CurrentCulture { get; set; }
        public string SupportedCultures { get; set; }
    }
}