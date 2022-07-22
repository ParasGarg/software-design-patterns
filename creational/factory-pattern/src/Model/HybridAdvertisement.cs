/**
 * Hybrid Advertisement Class
 */

namespace Patterns.Creational.Factory 
{
    class HybridAdvertisement: IAdvertisement {

        private Advertisement hybridAd;

        public HybridAdvertisement() {
            hybridAd = new Advertisement(
                AdType.Hybrid.ToString(),
                "Hybrid Eyebrow Text",
                "Hybrid Copy Text",
                "Hybrid CTA",
                "/images/cover-hybrid.png",
                "/images/logo-hybrid.png"
            );
        }

        public Advertisement GetAdvertisement() {
            return this.hybridAd;
        }

        public void PrintAdvertisement() { 
            Console.WriteLine(hybridAd.ToString());
        }
    }
}