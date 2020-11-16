using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketAssignment
{
    class RainBarrel : ContainerBase
    {
        public RainBarrel() : this(0, BarrelSize.Medium)
        {

        }

        public RainBarrel(int content) : this(content, BarrelSize.Medium)
        {
            
        }

        public RainBarrel(int content, BarrelSize size)
        {
            Content = Math.Max(0, content);
            Capacity = (int)size;
        }
    }
}
