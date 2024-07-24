using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class loggingService : IloggingService
    {
        public void LogInformation(string message)=>
        Console.WriteLine(message);
    }
}
