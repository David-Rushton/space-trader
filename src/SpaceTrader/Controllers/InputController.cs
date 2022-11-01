using System.Diagnostics;

namespace SpaceTrader.Controllers;

public class InputController
{
    public KeyPressResult WaitForKeyPress(int timeOutInMilliseconds)
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        while (true)
        {
            if (Console.KeyAvailable)
            {
                return new (Console.ReadKey(intercept: false), RequestedTimedOut: false);
            }

            if (timeOutInMilliseconds > 0 && stopWatch.ElapsedMilliseconds > timeOutInMilliseconds)
            {
                return new(ConsoleKeyInfo: null, RequestedTimedOut: true);
            }
        }
    }
}

public readonly record struct KeyPressResult(
    ConsoleKeyInfo? ConsoleKeyInfo,
    bool RequestedTimedOut
);
