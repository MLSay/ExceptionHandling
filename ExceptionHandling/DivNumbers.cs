using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This is exception Handling program
/// </summary>
namespace ExceptionHandling
{
    /// <summary>
    /// this is the public class div Numbers
    /// </summary>
    public class DivNumbers
    {
        /// <summary>
        /// this is an integer variable result.
        /// </summary>
        int result;
        /// <summary>
        /// this is the constructor
        /// </summary>
        public DivNumbers()
        {            
            result = 0;
        }
        /// <summary>
        /// this is a method called Division
        /// </summary>
        /// <param name="num1">This is the first parameter</param>
        /// <param name="num2">This is the second parameter</param>
     public void division(int num1, int num2)
        {            
            try
            {                
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
    }
 }