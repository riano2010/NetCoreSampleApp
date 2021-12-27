using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueConsumer
{
    public class MessageProcessor
    {
        public Dictionary<string, int> Redo = new Dictionary<string, int>();

        public void Process(string message)
        {
            if (message == "555")
            {

            }
            else
            {
                throw new InvalidOperationException("Упс!");
            }
        }
    }
}
