﻿using System.Threading.Tasks;
using Xamarin.Essentials;
using Xunit;

namespace DeviceTests
{
    public class Maps_Tests
    {
        const double testLatitude = 52.51852;
        const double testLongitude = 13.37621;
        const string mapName = "Bundestag";

        [Fact]
        [Trait(Traits.InteractionType, Traits.InteractionTypes.Human)]
        public async Task LaunchMap_CoordinatesDisplayCorrectPlace()
        {
            await Maps.OpenAsync(testLatitude, testLongitude, new MapsOpenOptions { Name = mapName });
        }

        [Fact]
        [Trait(Traits.InteractionType, Traits.InteractionTypes.Human)]
        public async Task LaunchMap_PlacemarkDisplayCorrectPlace()
        {
            var placemark = new Placemark
            {
                CountryName = "Deutschland",
                AdminArea = "Berlin",
                Thoroughfare = "Platz der Republik 1",
                Locality = "Berlin"
            };
            await Maps.OpenAsync(placemark, new MapsOpenOptions { Name = mapName });
        }
    }
}
