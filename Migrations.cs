using Codesanook.CultureSwitcher.Models;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace Codesanook.CultureSwitcher {
    public class Migrations : DataMigrationImpl {

        public int Create() {
            // Naming convention for Lambda parameter
            // prefer abbreviation when it is clear about the context 
            // prefer long name when it is hard to reference context

            // For Orchard migration, use:
            // table parameter for CreateTableCommand
            // column parameter for CreateColumnCommand
            // type parameter for ContentTypeDefinitionBuilder
            // part for ContentPartDefinitionBuilder

            // Create a content part
            ContentDefinitionManager.AlterPartDefinition(
                nameof(CultureSwitcherPart),
                part => part
                    .Attachable()
                    .WithDescription("Provide culture switcher part")
            );

            const string widgetName = "CultureSwitcherWidget";
            // Create a widget
            ContentDefinitionManager.AlterTypeDefinition(
                widgetName,
                type => type
                    .WithPart(nameof(CultureSwitcher))
                    .AsWidgetWithIdentity() // in Orchard.Widget assembly
            );

            return 1;
        }
    }
}