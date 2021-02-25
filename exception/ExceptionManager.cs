using System;

namespace exception
{
    public class ExceptionManager 
    {
        static int[] numbers = { 15, 5, 8, 12 };
        public static bool wrongAnswer = false;
        public static int GetNumber(int index)
        {
            int output = -1;

            try
            {
                output = numbers[index];
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
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