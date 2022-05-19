namespace InitHelperInformatMessage
{
    public class InitializationHelper
    {
        /// <summary>
        /// String initialization method
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string StringInIt(string message)
        {
            while (true)
            {
                Console.Write($"Enter {message}: ");
                var input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && !string.IsNullOrWhiteSpace(input))
                {
                    return input.ToUpper();
                }
                MessageInformant.ErrorOutput($"Value {input} must not be empty");
            }
        }
        /// <summary>
        /// Number(int) initialization method
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int IntInit(string message)
        {
            while (true)
            {
                Console.Write($"Enter {message}: ");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    return input;
                }
                MessageInformant.ErrorOutput($"Enter integer!");
            }
        }
        /// <summary>
        /// Number(double) initialization method
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static double DoubleInit(string message)
        {
            while (true)
            {
                Console.Write($"Enter {message}: ");
                if (double.TryParse(Console.ReadLine(), out double input))
                {
                    return input;
                }
                MessageInformant.ErrorOutput($"Enter number!");
            }
        }

    }
}