using Atata;

namespace PhpTravels.UITests.Components
{
    using _ = HotelEdit;

    public class HotelEdit : Page<_>
    {
        [FindByName(TermCase.LowerMerged)]
        [RandomizeStringSettings("AT Hotel {0}")]
        public TextInput<_> HotelName { get; private set; }

        public RichTextEditor<_> HotelDescription { get; private set; }

        [FindById("s2id_searching")]
        public AutoCompleteSelect<_> Location { get; private set; }

        public ButtonDelegate<HotelsPage, _> Submit { get; private set; }
        
        [FindByName("hoteltype")]
        public Select<_> HotelType { get; private set; }

        [FindByName("hotelstars")]
        public Select<_> HotelStars { get; private set; }

        [FindByName("ffrom")]
        public TextInput<_> FeaturedFrom { get; private set; }

        [FindByName("fto")]
        public TextInput<_> FeaturedTo { get; private set; }
    }
}
