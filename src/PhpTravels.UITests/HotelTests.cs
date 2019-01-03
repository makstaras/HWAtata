using Atata;
using NUnit.Framework;
using PhpTravels.UITests.Components;

namespace PhpTravels.UITests
{
    public class HotelTests : UITestFixture
    {
        [Test]
        public void Hotel_Add()
        {
            LoginAsAdmin();

            Go.To<HotelsPage>().
                Add.ClickAndGo().
                    HotelName.SetRandom(out string name).
                    HotelDescription.SetRandom(out string description).
                    Location.Set("London").
                    HotelType.Set("Hotel").
                    HotelStars.Set("5").
                    FeaturedFrom.Set("02/01/2019").
                    FeaturedTo.Set("12/01/2019").
                    Submit().
                Hotels.Rows[x => x.Name == name].Should.BeVisible();
        }

        [Test]
        public void Hotel_Edit()
        {
            LoginAsAdmin();

            Go.To<HotelsPage>().
                Add.ClickAndGo().
                    HotelName.SetRandom(out string name).
                    HotelDescription.SetRandom(out string description).
                    Location.Set("New York").
                    HotelType.Set("Guest House").
                    HotelStars.Set("3").
                    FeaturedFrom.Set("08/01/2019").
                    FeaturedTo.Set("09/01/2019").
                    Submit().
                Hotels.Rows[x => x.Name == name].Should.BeVisible();
            Go.To<HotelsPageSecond>().
                Edit.ClickAndGo().
                    Location.Set("Washington").
                    Submit().
                Hotels.Rows[x => x.Name == name && x.Location == "Washington"].Should.BeVisible();
        }

        [Test]
        public void Hotel_Room_Add()
        {
            LoginAsAdmin();

            Go.To<HotelsPage>().
                Add.ClickAndGo().
                    HotelName.SetRandom(out string name).
                    HotelDescription.SetRandom(out string description).
                    Location.Set("Istanbul").
                    HotelType.Set("Resort").
                    HotelStars.Set("2").
                    FeaturedFrom.Set("11/01/2019").
                    FeaturedTo.Set("22/01/2019").
                    Submit().
                Hotels.Rows[x => x.Name == name].Should.BeVisible();
            Go.To<RoomsPage>().
                Add.ClickAndGo().
                    RoomType.Set("Two-Bedroom Apartment").
                    Hotel.Set(name).
                    Price.SetRandom(out int priceValue).
                    Submit().
                Rooms.Rows[x => x.Hotel == name && x.Price == priceValue.ToString()].Should.BeVisible();
        }
    }
}
