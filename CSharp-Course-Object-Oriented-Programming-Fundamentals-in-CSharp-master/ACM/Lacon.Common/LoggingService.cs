using System;
using System.Collections.Generic;
using System.Text;

namespace Lacon.Common
{
    public static class LoggingService
    {
        public static void WriteToFile(List<ILoggable> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
