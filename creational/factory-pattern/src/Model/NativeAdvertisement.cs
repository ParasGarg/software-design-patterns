/**
 * Native Advertisement Class
 */

namespace Patterns.Creational.Factory 
{
    class NativeAdvertisement: IAdvertisement {

        private Advertisement nativeAd;

        public NativeAdvertisement() {
            nativeAd = new Advertisement(
                AdType.Native.ToString(),
                "Native Eyebrow Text",
                "Native Copy Text",
                "Native CTA",
                "/images/cover-native.png",
                "/images/logo-native.png"
            );
        }

        public Advertisement GetAdvertisement() {
            return this.nativeAd;
        }

        public void PrintAdvertisement() { 
            Console.WriteLine(nativeAd.ToString());
        }
    }
}