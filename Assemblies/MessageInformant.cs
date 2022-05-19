using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitHelperInformatMessage
{
    public class MessageInformant
    {
        /// <summary>
        /// Displays an error message
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static void ErrorOutput(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {message}");
            Console.ResetColor();
        }
        /// <summary>
        /// Displays a success message
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static void SuccessOutput(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Success: {message}");
            Console.ResetColor();
        }
    }
}