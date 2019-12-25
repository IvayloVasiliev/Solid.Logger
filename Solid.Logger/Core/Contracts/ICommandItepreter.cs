namespace Solid.Logger.Core.Contracts
{
    public interface ICommandItepreter
    {
        void AddAppender(string[] args);

        void AddMessage(string[] args);

        void PrintInfo();
    }
}
