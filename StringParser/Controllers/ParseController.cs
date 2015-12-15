/*
 * Created By: Hameed Goudat
 * DateTime: 12/14/2015 11:27:06
 * E-Mail: goudat@ymail.com
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StringParser.Controllers
{
    public class ParseController : ApiController
    {
        //write a program that parses a sentence and replaces each word with the following: 
        //first letter, number of distinct characters between first and last character, and last letter.  
        //For example, Smooth would become S4h.  Words are separated by spaces or non-alphabetic characters 
        //and these separators should be maintained in their original form and location in the answer.

        [HttpGet]
        public IEnumerable<object> Get([FromUri] List<string> list)
        {
            // Creating an output type List<object>
            List<string> output = new List<string>();

            // Apply the logic foreach item on the list
            foreach (var l in list)
            {
                var len = 0;
                len = l.Length;
                var firstChar = l.Substring(0, 1); // Get first character.
                var lastChar = l.Substring(len - 1, 1); // Get last character.
                output.Add(firstChar + (len - 2) + lastChar); // Add the first and last characters including the distinct number in between.
            }

            return output;
        }
    }
}
