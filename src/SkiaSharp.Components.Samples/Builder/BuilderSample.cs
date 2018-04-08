using System.Linq;

namespace SkiaSharp.Components.Samples
{
    public class BuilderSample : Builder
    {
        private static Item[] items =
        {
            new Item(IconPath.Activity, "Activity", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur congue condimentum neque vitae aliquet. Proin mollis tristique sapien id aliquam. Mauris iaculis dictum orci a egestas. Vivamus lorem mi, interdum et vestibulum non, ullamcorper in justo."),
            new Item(IconPath.Airplay, "Airplay", "Curabitur aliquam vel odio sit amet malesuada. Phasellus sodales dolor sed nisi consectetur, eget gravida arcu pulvinar. Suspendisse condimentum, lorem id maximus vulputate, ipsum mi convallis neque, eu pretium elit lectus quis est. Nam sit amet commodo ante, a commodo quam. Donec sollicitudin risus et nunc auctor mattis."),
            new Item(IconPath.AlertCircle, "Alert circle", "Praesent elementum vestibulum erat. Aliquam malesuada mi sed quam eleifend, id fringilla urna porttitor. Aenean nec neque interdum, volutpat sapien at, dignissim est."),
            new Item(IconPath.AlignJustify, "Align justify", "Quisque at urna felis. Ut semper, sapien et sagittis fermentum, justo ex blandit lacus, ut accumsan nisi odio et ante. Quisque scelerisque facilisis dictum. Etiam molestie leo quam, ac sodales mi laoreet in. Aenean sagittis scelerisque sapien, nec volutpat urna pulvinar ac."),
            new Item(IconPath.Aperture, "Aperture", "Duis eu neque laoreet, cursus risus non, ornare diam. Maecenas mauris justo, ornare in ligula vel, commodo rutrum velit. Quisque nisi nibh, commodo bibendum enim et, posuere posuere leo. Aliquam a arcu a libero consectetur malesuada et non purus. In rhoncus vestibulum elit vel lobortis. Pellentesque rutrum nulla sed quam ornare, sed porttitor ligula tincidunt."),
            new Item(IconPath.Book, "Book", "Morbi eu aliquet velit. Cras ligula nisl, tempor non rutrum at, ultricies a sapien. Proin nec libero a sapien lacinia ultricies. Vivamus placerat ultricies finibus."),
            new Item(IconPath.CloudRain, "Cloud rain", "Maecenas mollis lectus quam, sed feugiat urna maximus vel. Fusce at porttitor tortor, in tincidunt mauris. Vestibulum tempor, urna eget rhoncus aliquet, sapien nunc porttitor turpis, vitae tincidunt diam felis pulvinar nibh. "),
            new Item(IconPath.Globe, "Globe", "Suspendisse potenti. Mauris ultrices sed dolor sed pellentesque. Aliquam imperdiet euismod dui eu bibendum. Proin congue consectetur nisl, et venenatis lacus. Sed dictum, magna eget auctor blandit, odio dolor malesuada risus, a fermentum lectus urna ac mauris. "),
            new Item(IconPath.Sun, "Sun", "Suspendisse potenti. Mauris ultrices sed dolor sed pellentesque. Aliquam imperdiet euismod dui eu bibendum. Proin congue consectetur nisl, et venenatis lacus. Sed dictum, magna eget auctor blandit, odio dolor malesuada risus, a fermentum lectus urna ac mauris. "),
            new Item(IconPath.Moon, "Moon", "Interdum et malesuada fames ac ante ipsum primis in faucibus. Donec dui purus, accumsan ut ullamcorper a, mollis sed dolor. Quisque sed aliquet velit."),
        };

        public BuilderSample()
        {
            this.Factory = BuildCell;
            this.Measure = MeasureCell;
            this.ItemCount = items.Count();
        }

        private View BuildCell(int index) => new CellSample(items.ElementAt(index));

        private Measure MeasureCell(int index) => Components.Measure.Auto();

    }
}
