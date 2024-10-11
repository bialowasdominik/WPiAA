using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatedCode
{
    public class Logger
    {
        public void LogError(string message, DateTime timestamp)
        {
            Console.WriteLine($"ERROR: {FormatLogMessage(message, timestamp)}");
        }

        public void LogWarning(string message, DateTime timestamp)
        {
            Console.WriteLine($"WARNING: {FormatLogMessage(message, timestamp)}");
        }

        private string FormatLogMessage(string message, DateTime timestamp) 
        {
            string formattedTimestamp = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
            string formattedMessage = $"[{formattedTimestamp}] {message}";
            return formattedMessage;
        }
    }
}
