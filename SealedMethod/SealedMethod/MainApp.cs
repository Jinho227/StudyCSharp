using System;

namespace SealedMethod
{
    class Base
    {
        public virtual void SealMe()
        {
        }
    }

    class Derived : Base {
        public sealed override void SealMe()
        {
            base.SealMe();
        }
    }

    class WantToOverride : Derived
    {
        public override void SealMe()
        {

        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
        }
    }
}
