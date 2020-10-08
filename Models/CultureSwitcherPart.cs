using System.Collections.Generic;
using Orchard.ContentManagement;

namespace Codesanook.CultureSwitcher.Models {
    public class CultureSwitcherPart : ContentPart {
        public string CurrentCulture { get; set; }
        public IReadOnlyCollection<string> SupportedCultures { get; set; }
    }
}