using Atata;

namespace PhpTravels.UITests.Components
{
    using _ = HotelsPageSecond;

    [Url("/hotels")]
    [WaitForElement(WaitBy.Css, "div.pace-active", Until.VisibleThenMissingOrHidden, TriggerEvents.Init)]
    public class HotelsPageSecond : Page<_>
    {
        [FindByXPath("//*[@id='content']/div/div[2]/div/div/div[1]/div[2]/table/tbody/tr[1]/td[12]/span/a[2]")]
        public Link<HotelEdit, _> Edit { get; private set; }

        [FindByClass("xcrud-list")]
        public Table<HotelRow, _> Hotels { get; private set; }

        public class HotelRow : TableRow<_>
        {
            public Text<_> Name { get; private set; }

            public Text<_> Location { get; private set; }
        }
    }
}