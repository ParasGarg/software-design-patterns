/**
 * Advertisement Builder Class
 */

namespace Patterns.Creational.Builder 
{
    class AdvertisementBuilder: IAdvertisement<Advertisement, AdvertisementBuilder> {

        private Advertisement advertisement;

        /*
         * Constructor
         */
        public AdvertisementBuilder() {
            advertisement = new Advertisement();
        }

        /*
         * Reset Method
         */
        public void Reset() {
            advertisement = new Advertisement();
        }

        /*
         * Setter function: Ad Type
         */
        public AdvertisementBuilder SetAdType(String type) {
            advertisement.AdType = type;
            return this;
        }

        /*
         * Setter function: Eyebrow Text
         */
        public AdvertisementBuilder SetEyebrowText(String eyebrow) {
            advertisement.EyebrowText = eyebrow;
            return this;
        }

        /*
         * Setter function: Copy Text
         */
        public AdvertisementBuilder SetCopyText(String copy) {
            advertisement.CopyText = copy;
            return this;
        }

        /*
         * Setter function: Call To Action
         */
        public AdvertisementBuilder SetCallToAction(String cta) {
            advertisement.CallToAction = cta;
            return this;
        }

        /*
         * Setter function: Cover Image Path
         */
        public AdvertisementBuilder SetCoverImage(String coverImgPath) {
            advertisement.CoverImage = coverImgPath;
            return this;
        }

        /*
         * Setter function: Logo Image Path
         */
        public AdvertisementBuilder SetLogoImage(String logoImgPath) {
            advertisement.LogoImage = logoImgPath;
            return this;
        }

        /*
         * Validator 
         */
        public void Validate() {
            if (advertisement.AdType.Equals("") || advertisement.CopyText.Equals("") || advertisement.CallToAction.Equals("")) {
                throw new ArgumentNullException("One or more required values are either empty or null");
            }
        }

        /*
         * Function to build and return the object
         */
        public Advertisement Build() {
            this.Validate();
            return advertisement;
        }
    }
}
