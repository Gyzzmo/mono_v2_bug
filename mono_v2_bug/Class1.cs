using CitizenFX.Core;

namespace mono_v2_bug
{
    internal class Class1
    {
        internal async Coroutine Test()
        {
            Debug.WriteLine("Class1.Test start");
            await Coroutine.Wait(1000);
            Debug.WriteLine("Class1.Test end");
        }
    }
}
