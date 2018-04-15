using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{

    public class CustomException : Exception
    {
        public CustomException(string message, Exception innetException)
        :base(message,innetException)
        {
            Console.WriteLine("Error Occurre in Custom");
        }
    }
    class Program
    {



        private static object streamReader;

        static void Main(string[] args)
        {
            try
            {
                var calculcator = new Calculator();
                calculcator.Divide(5, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occured");
            }
            finally
            {
                Console.WriteLine(" All Done! ");
            }

      
            try
            {
                using (var streamReader = new StreamReader(@"c:\users"))
                {
                    var content = streamReader.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
            catch (Exception e)
            {
 
                throw new CustomException("Couldn't do stuff....",e);
            }
        }
    }

}
