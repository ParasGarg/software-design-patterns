/**
 * Advertisement Class
 */

namespace Patterns.Creational.Builder 
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

        override
        public String ToString() {
            return $"AdType={AdType}, Eyebrow={EyebrowText}, Copy={CopyText}, CTA={CallToAction}, CoverImage={CoverImage}, LogoImage={LogoImage}";
        }
    }
}
