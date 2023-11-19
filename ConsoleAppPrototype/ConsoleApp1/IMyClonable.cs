using ConsoleApp1.Models;

namespace ConsoleApp1
{
    /// <summary>
    /// Interface realising clone methods of concrete class BaseProduct
    /// </summary>
    internal interface IMyClonable
    {
        public BaseProduct CloneMemberWise();

        public BaseProduct CloneCtor();
    }
}
