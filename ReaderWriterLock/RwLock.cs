using System;
using System.Threading;

namespace ReaderWriterLock
{
    public class RwLock : IRwLock
    {
        private BoolWrapper isWriting = BoolWrapper.False;
        private object locker;

        public void ReadLocked(Action action)
        {
            while (Interlocked.CompareExchange(ref isWriting, BoolWrapper.False, BoolWrapper.False) == BoolWrapper.False)
            {
                action();
                return;
            }
        }

        public void WriteLocked(Action action)
        {
            while (Interlocked.CompareExchange(ref isWriting, BoolWrapper.True, BoolWrapper.False) == BoolWrapper.False)
            {
                action();
                return;
            }
        }
    }
}