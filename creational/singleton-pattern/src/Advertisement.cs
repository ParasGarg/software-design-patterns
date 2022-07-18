/**
 * Advertisement Class
 */

namespace Patterns.Creational.Singleton
{
    public enum AdType {
        Banner = 1,
        Native = 2,
        Hybrid = 3
    }

    class Advertisement {

        public String AdType = "";

        public String EyebrowText = "";

        public String CopyText = "";

        public String CallToAction = "";

        public String CoverImage = "";

        public String LogoImage = "";

        public Advertisement(String adType, String eyebrow, String copy, String cta, String coverImg, String logoImg) {
            this.AdType = adType;
            this.EyebrowText = eyebrow;
            this.CopyText = copy;
            this.CallToAction = cta;
            this.CoverImage = coverImg;
            this.LogoImage = logoImg;
        }

        override
        public String ToString() {
            return $"AdType={AdType}, Eyebrow={EyebrowText}, Copy={CopyText}, CTA={CallToAction}, CoverImage={CoverImage}, LogoImage={LogoImage}";
        }
    }
}