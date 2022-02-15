using System;

namespace Decorator
{
    public abstract class BeverageBase
    {
        public Size Size { get; set; }

        public string Description { get; set; } = "Unknow BeverageBase";

        public abstract float Cost();
    }
}
