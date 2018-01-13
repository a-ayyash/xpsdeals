using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using ExpediaInterview;
using ExpediaInterview.Models;
using ExpediaInterview.Models.Response.Flight;
using ExpediaInterview.Models.Response.Hotel;
using ExpediaInterview.Models.Response.Offer;
using ExpediaInterview.Models.Response.Package;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace DealObjectGraphUnitTests
{
    [TestClass]
    public class DealUnitTests
    {
        private const string PACKAGE_SEARCH_URL = "https://www.expedia.com/go/package/search/FlightHotel/2018-02-10/2018-02-16?FromAirport=WAW&Destination=PUJ&HotelId=18919488&NumAdult=2&DestinationId=601906&dealMarker=3-5,-1,201801130703,11,10102020,3765.52,_";
        private const string FLIGHT_SEARCH_URL = "https://www.expedia.com/go/flight/search/RoundTrip/2018-02-10/2018-02-16?FromAirport=WAW&ToAirport=PUJ&NumAdult=2";
        private const string HOTEL_SEARCH_URL = "https://www.expedia.com/go/hotel/info/18919488/2018-02-10/2018-02-16";

        private static OfferInfo OfferDetails;
        private static UserInfo User;
        private static PackageDetails Package;
        private static HotelDetails Hotel;
        private static FlightDetails Flight;

        [ClassInitialize]
        public static void TestFullDealGraph(TestContext context)
        {
            var expectedContent = System.IO.File.ReadAllText("FullResponse.json");
            
            var deal = JsonConvert.DeserializeObject<Deal>(expectedContent);

            OfferDetails = deal.OfferDetails;
            User = deal.User;
            Package = deal.OfferCollections.Packages[0];
            Flight = deal.OfferCollections.Flights[0];
            Hotel = deal.OfferCollections.Hotels[0];
        }

        private void CheckForNulls(object obj, Type type)
        {
            PropertyInfo[] properties = type.GetProperties();

            foreach (var property in properties)
            {
                if (property.PropertyType.IsClass)
                {
                    if (!property.PropertyType.FullName.StartsWith("System.") && !property.PropertyType.FullName.StartsWith("Microsoft."))
                    {
                        CheckForNulls(property.GetValue(obj), property.PropertyType);
                    }
                }

                Assert.IsNotNull(property.GetValue(obj), "KeyName: " + property.Name + " Type: " + type.Name);
            }

        }

        [TestMethod]
        public void TestOfferInfo()
        {
            CheckForNulls(OfferDetails, typeof(OfferInfo));
        }

        [TestMethod]
        public void TestUserInfo()
        {
            CheckForNulls(User, typeof(UserInfo));
        }

        [TestMethod]
        public void TestFlight()
        {
            CheckForNulls(Flight, typeof(FlightDetails));
        }

        [TestMethod]
        public void TestHotel()
        {
            CheckForNulls(Hotel, typeof(HotelDetails));
        }

        [TestMethod]
        public void TestPackage()
        {
            CheckForNulls(Package, typeof(PackageDetails));
        }

        [TestMethod]
        public void TestURLDecoding()
        {
            Assert.AreEqual(Package.URLs.PackageSearchUrl, PACKAGE_SEARCH_URL);
            Assert.AreEqual(Package.URLs.FlightDeeplinks.FlightSearchUrl, FLIGHT_SEARCH_URL);
            Assert.AreEqual(Package.URLs.HotelDeeplinks.HotelInfositeUrl, HOTEL_SEARCH_URL);
        }

        private void TestOfferDestination(OfferDestination origin)
        {
            throw new NotImplementedException();
        }


        private void TestPackagePricingInfo(PackagePricingInfo packagePricing)
        {
            Assert.AreEqual(packagePricing.PerPsgrPackagePrice, 1882.0);
            Assert.AreEqual(packagePricing.TotalPackagePrice, 3765.52);
            Assert.AreEqual(packagePricing.PerPsgrSavings, 1499.0);
            Assert.AreEqual(packagePricing.TotalSavings, 2998.14);
            Assert.AreEqual(packagePricing.PercentSavings, 45.0);
            Assert.AreEqual(packagePricing.SavingsPctOfHotel, 60.0);
            Assert.AreEqual(packagePricing.SavingsPctOfFlight, 166.0);
            Assert.AreEqual(packagePricing.Currency, "USD");
        }

        private void TestFlightDestination(FlightDestination destination)
        {
            Assert.AreEqual(destination.RegionID, 601906);
            Assert.AreEqual(destination.LongName, "Long Name");
            Assert.AreEqual(destination.Country, "ABC");
            Assert.AreEqual(destination.City, "city");
            Assert.AreEqual(destination.TLA, "TLA");
            Assert.AreEqual(destination.MetroCode, "SDQ");
        }

        private void TestOfferDateRange(OfferDateRange dateRange)
        {
            Assert.AreEqual(dateRange.TravelStartDate, new DateTime(2018, 2, 10));
            Assert.AreEqual(dateRange.TravelEndDate, new DateTime(2018, 2, 16));
        }


        private void TestPackageInfo(PackageInfo package)
        {
            //Assert.AreEqual(package.BrandedDealsIdentifier, BRANDED_DEAL_ID);
        }

        private void TestFlightPricingInfo(FlightPricingInfo flightPricing)
        {
            Assert.AreEqual(flightPricing.FlightTotalBaseFare, 926.0);
            Assert.AreEqual(flightPricing.FlightTotalTax, 877.64);
            Assert.AreEqual(flightPricing.FlightTotalPrice, 1803.64);
            Assert.AreEqual(flightPricing.FlightPerPsgrBaseFare, 463.0);
            Assert.AreEqual(flightPricing.FlightPerPsgrTax, 438.82);
            Assert.AreEqual(flightPricing.FlightPerPsgrBaseFarePlusTax, 0.0);
            Assert.AreEqual(flightPricing.FlightPerPsgrTotalPrice, 901.82);
            Assert.AreEqual(flightPricing.TrendAgencyFlightPrice, 0.0);
            Assert.AreEqual(flightPricing.ChangeFromTrendPercentage, 0.0);
            Assert.AreEqual(flightPricing.Currency, "USD");
        }

        private void TestFlightInfoBase(FlightInfoBase flight)
        {
                Assert.AreEqual(flight.LengthOfStay, 6);
                Assert.AreEqual(flight.TripType, "ROUND_TRIP");
                Assert.AreEqual(flight.FlightCarrierShortName, "DL");
        }

        private void TestHotelPricingInfoForPackage(HotelPricingInfoForPackage hotelPricing)
        {
            Assert.AreEqual(hotelPricing.HotelPerPsgrBaseRate, 2480.01);
            Assert.AreEqual(hotelPricing.HotelPerPsgrTaxesAndFees, 1.3333);
            Assert.AreEqual(hotelPricing.HotelPerPsgrTotalRate , 2480.01);
            Assert.AreEqual(hotelPricing.HotelTotalBaseRate, 4960.02);
            Assert.AreEqual(hotelPricing.HotelTotalRate, 4960.02);
            Assert.AreEqual(hotelPricing.HotelTotalTaxesAndFees, 3.3);
        }

        private void TestHotelInfo(HotelInfo hotel)
        {
            Assert.AreEqual(hotel.ID, 123);
            Assert.AreEqual(hotel.Longitude, -12.5555);
            Assert.AreEqual(hotel.Latitude, 138383839.193939393923);
            Assert.AreEqual(hotel.DestinationRegionID, 2321);
            Assert.AreEqual(hotel.StarRating, 4.5);
            Assert.AreEqual(hotel.GuestReviewRating, 5.0);
            Assert.AreEqual(hotel.ReviewTotal, 4.3);
            Assert.AreEqual(hotel.VipAccess, true);
            Assert.AreEqual(hotel.IsOfficialRating, true);
            Assert.AreEqual(hotel.Name, "Hotel Name");
            Assert.AreEqual(hotel.LocalizedName, "اسم الفندق");
            Assert.AreEqual(hotel.Destination, "Hotel Destination");
            Assert.AreEqual(hotel.LongDestination, "Hotel Long Destination");
            Assert.AreEqual(hotel.StreetAddress, "Street Address 123");
            Assert.AreEqual(hotel.City, "Hotel City");
            Assert.AreEqual(hotel.Province, "Province");
            Assert.AreEqual(hotel.CountryCode, "ABC");
            Assert.AreEqual(hotel.ImageUrl, "https://www.one.com/two.jpg");
        }
    }
}
