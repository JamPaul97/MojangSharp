using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojangSharp.Exceptions
{
    public class UUIDException :Exception
    {
        private string message;
        private string details;
        public string Message { get { return this.message; } } 
        public string Details { get { return this.details; } }
        internal UUIDException(string message,string details = "Details not provided")
        {
            this.message = message;
            this.details = details;
        }
    }
        
}
