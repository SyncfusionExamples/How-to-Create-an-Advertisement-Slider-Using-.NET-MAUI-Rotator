using System;
using System.Collections.Generic;
using System.Text;

namespace AdvertisementRotator
{
    public class AdvertisementModel
    {
        public string Image { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Offer { get; set; }

        public AdvertisementModel(string image, string title, string description, string offer)
        {
            Image = image;
            Title = title;
            Description = description;
            Offer = offer;
        }

    }
}
