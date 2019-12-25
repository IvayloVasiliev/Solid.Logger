namespace Solid.Logger.Appenders
{
  
    using Contracts;
    using Layouts.Contracts;
    using Solid.Logger.Loggers.Contracts;
    using Solid.Logger.Loggers.Enums;
    using System.IO;

    public class FileAppender : Appender
    {
        private const string path = "C:\\Users\\ivail\\source\\repos\\Solid.Logger\\Solid.Logger\\log.txt";

        private readonly ILogFile logFile;

        public FileAppender(ILayout layout, ILogFile logFile)
            : base(layout)
        {
            this.logFile = logFile;
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {

            if (reportLevel >= this.ReportLevel)
            {
                this.MessageCount++;
                string content = string.Format(this.Layout.Format, dateTime, reportLevel, message) 
                    + "\n";
                this.logFile.Write(content);
                File.AppendAllText(path, content);
            }
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.GetType().Name}," +
                $" Report level: {this.ReportLevel.ToString().ToUpper()}, Messages appended:" +
                $" {this.MessageCount}, File size: {this.logFile.Size}";
        }
    }
}
