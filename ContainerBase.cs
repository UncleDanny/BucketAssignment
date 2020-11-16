using System;
using System.ComponentModel;

namespace BucketAssignment
{
    public abstract class ContainerBase
    {
        public event CancelEventHandler OnContainerOverflowing;
        public event Action<ContainerBase> OnContainerFull;
        public event Action<ContainerBase> OnContainerOverflowed;

        public int Content { get; set; }

        public int Capacity { get; protected set; }

        public int Fill(int amount)
        {
            if (amount <= 0)
            {
                return -1;
            }

            Console.WriteLine("Filling container...");
            if (Content + amount > Capacity)
            {
                Console.WriteLine($"The container will overflow. The limit of the container is {Capacity}.");

                CancelEventArgs args = new CancelEventArgs();
                OnContainerOverflowing?.Invoke(this, args);

                if (args.Cancel)
                {
                    Console.WriteLine("Overflowing has been cancelled.");
                    return -1;
                }
            }

            Content += amount;
            if (Content < Capacity)
            {
                Console.WriteLine($"The container now has {Content} units in it.");
                return 0;
            }

            OnContainerFull?.Invoke(this);
            if (Content == Capacity)
            {
                Console.WriteLine("The container is full.");
                return 0;
            }

            int overflowAmount = Content - Capacity;
            Console.WriteLine("The container has overflowed.");
            OnContainerOverflowed?.Invoke(this);
            return overflowAmount;
        }

        public void Empty()
        {
            Empty(Content);
        }

        public void Empty(int amount)
        {
            if (amount <= 0)
            {
                return;
            }

            Content = Math.Max(Content - amount, 0);
        }
    }
}
