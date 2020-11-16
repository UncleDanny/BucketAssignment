using System;
using System.Security.Principal;

namespace BucketAssignment
{
    class Bucket : ContainerBase
    {
        public const int MinCapacity = 10;
        public const int DefaultCapacity = 12;

        public Bucket() : this(0, DefaultCapacity)
        {

        }

        public Bucket(int content) : this(content, DefaultCapacity)
        {

        }

        public Bucket(int content, int capacity)
        {
            Content = Math.Max(0, content);
            Capacity = Math.Max(MinCapacity, capacity);
        }

        public void Fill(Bucket bucket)
        {
            int overflowAmount = Fill(bucket.Content);
            if (overflowAmount >= 0)
            {
                bucket.Empty(bucket.Content - overflowAmount);
            }
        }
    }
}
