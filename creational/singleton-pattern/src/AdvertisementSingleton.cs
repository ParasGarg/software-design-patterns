/**
 * Singleton Class
 */

namespace Patterns.Creational.Singleton
{
    public sealed class AdvertisementSingleton {

        private static Advertisement? advertisement = null;
        private static int Counter = 0;

        private static AdvertisementSingleton? instance = null;

        private AdvertisementSingleton(String adType, String eyebrow, String copy, String cta, String coverImg, String logoImg) {
            advertisement = new Advertisement(adType, eyebrow, copy, cta, coverImg, logoImg);
            Console.WriteLine("Advertisement Object Created");
        }

        public static AdvertisementSingleton GetInstance(String adType, String eyebrow, String copy, String cta, String coverImg, String logoImg) {
            if (instance == null) {
                Counter++;
                instance = new AdvertisementSingleton(adType, eyebrow, copy, cta, coverImg, logoImg);
            }
            return instance;
        }

        public void PrintCounter() {
            Console.WriteLine("Number of instances created {0}", Counter);
        }

        public void PrintAdvertisement() {
            Console.WriteLine(advertisement != null ? advertisement.ToString() : "");
        }
    }
}
