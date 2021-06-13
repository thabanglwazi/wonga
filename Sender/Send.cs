using System;
using System.Collections.Generic;
using System.Text;

namespace Sender
{
    public class Send
    {
        //property methods
        public string Name { get; set; }
        public string Message { get; set; }
       
        //constructors
       public Send() { }

        public Send(string name, string message)
        {
            Name= name;
            Message = message;
        }
        //function or methods
        //uses name and message property to generate message to be sent to a MQ
        public string CompileMessage()
        {
            return $"{Message}, {Name}";
        }

    }
}
