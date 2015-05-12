using System.Diagnostics;
using WebApplication3.Interfaces;

namespace WebApplication3.Impl
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Debug.Print(message);
        }
    }
}