namespace Misc
{
    public class MyService : IMyService
    {
        public async ValueTask DisposeAsync()
        {
            await Task.Delay(100);
        }

        public void DoTheThing() => Console.WriteLine("I did the thing!");
    }
}
