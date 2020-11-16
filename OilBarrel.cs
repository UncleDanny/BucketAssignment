using System;

namespace BucketAssignment
{
    class OilBarrel : ContainerBase
    {
        public OilBarrel() : this(content: 0)
        {

        }

        public OilBarrel(int content)
        {
            Content = Math.Max(0, content);
            Capacity = 159;
        }
    }
}
