/*Caroline Hana
10-25-2022
Asking for the users name and what time they woke up
Peer Review- Marcel R. The program ran well. Asked for two strings which were name and time and output them in a sentence. Solid work :)
*/


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HanaC_AskingQuestionsEndpoints.Controllers
{
    [Route("[controller]")]
    public class AskingQuestions : Controller
    {
       [HttpGet]
       [Route("Questions/{name}/{time}")]

       public string questions(string name, string time)
       {
            return $"Hello {name}, you woke up at {time}.";
       }
    }
}