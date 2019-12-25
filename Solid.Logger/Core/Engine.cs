namespace Solid.Logger.Core
{
    using Solid.Logger.Appenders.Contracts;
    using Solid.Logger.Core.Contracts;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Engine : IEngine
    {
        private ICommandItepreter commandItepreter;

        public Engine(ICommandItepreter commandItepreter)
        {
            this.commandItepreter = commandItepreter;
        }

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                this.commandItepreter.AddAppender(inputArgs);
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] inputArgs = input.Split('|');
                this.commandItepreter.AddMessage(inputArgs);


                input = Console.ReadLine();
            }

            this.commandItepreter.PrintInfo();
        }
    }
}
