using System;

namespace Patterns.Creational.Builder
{
    class BuilderPattern {

        public static void Main(String[] args) {

            Advertisement bannerAd = (new AdvertisementBuilder())
                .SetAdType(AdType.Banner.ToString())
                .SetCopyText("Banner Ad")
                .SetCallToAction("Banner Ad CTA")
                .SetCoverImage("/images/banner.png")
                .Build();

            Advertisement nativeAd = (new AdvertisementBuilder())
                .SetAdType(AdType.Native.ToString())
                .SetCopyText("Native Ad")
                .SetCallToAction("Native Ad CTA")
                .SetCoverImage("/images/nativeCover.png")
                .SetLogoImage("/images/nativeLogo.png")
                .Build();

            Console.WriteLine("Hello Builder Pattern");
            Console.WriteLine($"Banner Ad:: {bannerAd.ToString()}");
            Console.WriteLine($"Native Ad:: {nativeAd.ToString()}");
        }
    }
}