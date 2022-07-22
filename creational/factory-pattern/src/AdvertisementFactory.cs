/**
 * Advertisment Factory
 */

namespace Patterns.Creational.Factory 
{
    class AdvertisementFactory: IAdvertisementFactory {

        private IAdvertisement advertisement;
    
        public AdvertisementFactory(AdType adType) {
            switch(adType) {
                case AdType.Banner:
                    advertisement = new BannerAdvertisement();
                    break;
                
                case AdType.Native:
                    advertisement = new NativeAdvertisement();
                    break;

                default:
                    advertisement = new HybridAdvertisement();
                    break;
            }
        }

         public IAdvertisement GetAdvertisement() {
            return this.advertisement;
        }
    }
}