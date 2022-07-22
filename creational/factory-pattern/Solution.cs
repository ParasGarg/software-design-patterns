/**
 * Solution File
 */

namespace Patterns.Creational.Factory
{
    class Solution {

        public static void Main (String[] args) {

            Console.WriteLine("\nGetting a Banner Advertisement Object");
            IAdvertisement bannerAd = (new AdvertisementFactory(AdType.Banner)).GetAdvertisement();
            bannerAd.PrintAdvertisement();


            Console.WriteLine("\nGetting a Native Advertisement Object");
            IAdvertisement nativeAd = (new AdvertisementFactory(AdType.Native)).GetAdvertisement();
            nativeAd.PrintAdvertisement();


            Console.WriteLine("\nGetting a Hybrid Advertisement Object");
            IAdvertisement hybridAd = (new AdvertisementFactory(AdType.Hybrid)).GetAdvertisement();
            hybridAd.PrintAdvertisement();
        }
    }
}