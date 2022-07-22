/**
 * Banner Advertisement Class
 */

namespace Patterns.Creational.Factory 
{
    class BannerAdvertisement: IAdvertisement {

        private Advertisement bannerAd;

        public BannerAdvertisement() {
            bannerAd = new Advertisement(
                AdType.Banner.ToString(),
                "Banner Eyebrow Text",
                "Banner Copy Text",
                "Banner CTA",
                "/images/cover-banner.png",
                "/images/logo-banner.png"
            );
        }

        public Advertisement GetAdvertisement() {
            return this.bannerAd;
        }

        public void PrintAdvertisement() { 
            Console.WriteLine(bannerAd.ToString());
        }
    }
}