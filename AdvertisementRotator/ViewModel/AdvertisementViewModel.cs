using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AdvertisementRotator
{
    public class AdvertisementViewModel
    {

        public ObservableCollection<AdvertisementModel> AdvertisementCollection { get; set; }

        public AdvertisementViewModel()
        {
            AdvertisementCollection =
                new ObservableCollection<AdvertisementModel>()
                {
                new AdvertisementModel(
                    "offer1.png",
                    "Summer Sale",
                    "Get exciting discounts on all products.",
                    "Up to 50% OFF"),

                new AdvertisementModel(
                    "offer2.png",
                    "Travel Deals",
                    "Book your dream destination now.",
                    "Starting from ₹999"),

                new AdvertisementModel(
                    "offer3.png",
                    "Food Festival",
                    "Enjoy delicious meals from top restaurants.",
                    "Buy 1 Get 1 Free")
                };
        }

    }
}
