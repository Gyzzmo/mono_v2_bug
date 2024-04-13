using CitizenFX.Core;

namespace mono_v2_bug
{
    public class Main : BaseScript
    {
        [Tick]
        private async Coroutine Test()
        {
            Debug.WriteLine("Main.Test start");
            await Coroutine.Wait(1000);
            var class1 = new Class1();
            await class1.Test();
            Debug.WriteLine("Main.Test end");
        }
    }
}
