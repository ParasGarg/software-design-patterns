/**
 * Interface to define the basic skeleton
 */

namespace Patterns.Creational.Builder 
{
    interface IAdvertisement<T, R> {
        public void Reset();
        public R SetAdType(String type);
        public R SetEyebrowText(String eyebrow);
        public R SetCopyText(String copy);
        public R SetCallToAction(String cta);
        public R SetCoverImage(String coverImgPath);
        public R SetLogoImage(String logoImgPath);
        public T Build();
    }
}
