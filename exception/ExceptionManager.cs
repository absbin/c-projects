using System;

namespace exception
{
    // public static class ExceptionManager
    public class ExceptionManager
    {
        public static int[] numbers = { 15, 5, 8, 12 };
        public static bool wrongAnswer = false;
        public static int GetNumber(int index)
        {
            int output = -1;

            try
            {
                output = numbers[index];
            }
            catch (System.Exception exception_test)
            {
                Console.WriteLine(exception_test.StackTrace);
                Console.WriteLine(exception_test.Message);
            }
            finally
            {
                if (output == -1)
                {
                    Console.WriteLine("there was ann error with input");
                    wrongAnswer = true;
                }
                else
                {
                    wrongAnswer = false;
                }
            }
            return output;
        }
    }
}