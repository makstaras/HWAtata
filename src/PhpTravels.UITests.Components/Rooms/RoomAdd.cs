using Atata;

namespace PhpTravels.UITests.Components
{
    using _ = RoomAdd;

    public class RoomAdd : Page<_>
    {
        [FindById("s2id_autogen1")]
        public AutoCompleteSelect<_> RoomType { get; private set; }

        [FindById("s2id_autogen3")]
        public AutoCompleteSelect<_> Hotel { get; private set; }

        [FindByName("basicprice")]
        [RandomizeNumberSettings]
        public NumberInput<_> Price { get; private set; }

        public ButtonDelegate<HotelsPage, _> Submit { get; private set; }
    }
}
