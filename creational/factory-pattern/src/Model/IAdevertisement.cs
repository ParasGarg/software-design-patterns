/**
 * Interface to define the basic skeleton
 */

namespace Patterns.Creational.Factory 
{
    interface IAdvertisement {

        public Advertisement GetAdvertisement();

        public abstract void PrintAdvertisement();
    }
}