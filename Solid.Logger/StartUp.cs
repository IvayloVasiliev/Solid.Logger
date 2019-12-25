namespace Solid.Logger
{
    using Solid.Logger.Core;
    using Solid.Logger.Core.Contracts;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICommandItepreter commandItepreter = new CommandIntepreter();
            IEngine engine = new Engine(commandItepreter);
            engine.Run();

        }
    }
}
