/**
 * Solution File
 */

namespace Patterns.Creational.Singleton
{
    class Solution {

        public static void Main (String[] args) {

            AdvertisementSingleton bannerAd = AdvertisementSingleton.GetInstance(
                    AdType.Banner.ToString(),
                    "Banner Eyebrow Text",
                    "Banner Copy Text",
                    "Banner CTA",
                    "/images/cover-banner.png",
                    "/images/logo-banner.png"
            );
            bannerAd.PrintCounter();
            bannerAd.PrintAdvertisement();

            // Update the ad
            Console.WriteLine("\nTrying to update Banner Ad to Hybrid Ad\n");

            AdvertisementSingleton updateAd = AdvertisementSingleton.GetInstance(
                    AdType.Hybrid.ToString(),
                    "Hybrid Eyebrow Text",
                    "Hybrid Copy Text",
                    "Hybrid CTA",
                    "/images/cover-hybrid.png",
                    "/images/logo-hybrid.png"
            );
            updateAd.PrintCounter();
            updateAd.PrintAdvertisement();

            // Checking if ad is updated
            Console.WriteLine("\nHas Ad object updated: {0}", !bannerAd.Equals(updateAd));
        }
    }
}